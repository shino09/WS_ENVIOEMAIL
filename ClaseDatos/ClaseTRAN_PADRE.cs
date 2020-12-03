using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dim.rutinas;
using System.Data;
using System.Net.Mail;
using System.Net.Mime;
using System.Configuration;
using System.Net;
namespace ClaseDatos
{
    public class ClaseTRAN_PADRE
    {
        SqlQuery sqlquery = new SqlQuery();
        RutinasGenerales rg = new RutinasGenerales();

        /**************OBTIENE EMAIL Y ORIGEN DE IDPADRE***********/
        public ClaseDatosTRAN_PADRE ObtenerDatosIdPadre(string idPadre)
        {
            DataSet ds;
            ClaseDatosTRAN_PADRE datos = new ClaseDatosTRAN_PADRE();
            string sqlstr = "";

            try
            {
                sqlstr = "EXEC P_GET_Datos_TRANPADRE " + "'" + idPadre + "'";

                if (rg.PalabrasClaveSQL(sqlstr))
                {
                    datos.TRAN_PADRE_ORIGEN = "";
                    datos.TRAN_PADRE_EMAIL = "";
                }
                else
                {

                    ds = sqlquery.ExecuteDataSet(sqlstr);

                    if (ds != null && ds.Tables.Count > 0)
                    {
                        datos.TRAN_PADRE_ORIGEN = ds.Tables[0].Rows[0]["TRAN_PADRE_ORIGEN"].ToString();
                        datos.TRAN_PADRE_EMAIL = ds.Tables[0].Rows[0]["TRAN_PADRE_EMAIL"].ToString();
                    }
                }

                return datos;

            }
            catch (Exception e)
            {
                datos.TRAN_PADRE_ORIGEN = "";
                datos.TRAN_PADRE_EMAIL = "";
            }

            return datos;
        }


        /**************OBTIENE LOS ARCHIVOS DE TODOS LAS TRANSACCIONES QUE TENGAN MISMO IDPADRE***********/
        public List<ClaseDatosEnvioResumenCarga> ObtenerResumenCarga(string idPadre)
        {
            List<ClaseDatosEnvioResumenCarga> lista = new List<ClaseDatosEnvioResumenCarga>();
            DataSet ds;
            string sqlstr = "";

            try
            {
                //sqlstr = "EXEC P_GET_archivos_TRANPADREVIEJO " + "'" + idPadre + "'";
                sqlstr = "EXEC P_GET_archivos_TRANPADRE " + "'" + idPadre + "'";
               
                if (rg.PalabrasClaveSQL(sqlstr))
                {
                    lista = null;
                    return lista;

                }
                else
                {
                    ds = sqlquery.ExecuteDataSet(sqlstr);

                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        for (int cont = 0; cont < ds.Tables[0].Rows.Count; cont++)
                        {
                            ClaseDatosEnvioResumenCarga datos = new ClaseDatosEnvioResumenCarga();
                            datos.TransaccionPadre = ds.Tables[0].Rows[cont]["transaccionPadre"].ToString();
                            datos.NRO_IDENT_PART = ds.Tables[0].Rows[0]["NRO_IDENT_PART"].ToString();
                            datos.COD_PART = ds.Tables[0].Rows[0]["COD_PART"].ToString();
                            datos.Transaccion = ds.Tables[0].Rows[cont]["transaccion"].ToString();
                            datos.NombreArchivo = ds.Tables[0].Rows[cont]["nombreArchivo"].ToString();
                            //string[] separadorNombre = datos.NombreArchivo.Split('_');
                            //string nombre = separadorNombre[1];
                            //datos.NombreArchivo = nombre;
                            
                            lista.Add(datos);
                        }
                    }
                }

                return lista;

            }
            catch (Exception e)
            {
                lista = null;
                return lista;
            }
        }



        /**************OBTIENE LOS ERORRES DE LAS TRANSACCIONES CON UN MISMO  IDPADRE***********/
        public List<ClaseDatosErrorValidacion> ObtenerErrorValidacion(string idPadre)
        {
            List<ClaseDatosErrorValidacion> lista = new List<ClaseDatosErrorValidacion>();
            DataSet ds;
            string sqlstr = "";

            try
            {
                //sqlstr = "EXEC P_GET_Validate_File_Err_TRANPADREVIEJO " + "'" + idPadre + "'";
                sqlstr = "EXEC P_GET_Validate_File_Err_TRANPADRE " + "'" + idPadre + "'";


                if (rg.PalabrasClaveSQL(sqlstr))
                {
                    lista = null;
                    return lista;

                }
                else
                {

                    ds = sqlquery.ExecuteDataSet(sqlstr);

                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        for (int cont = 0; cont < ds.Tables[0].Rows.Count; cont++)
                        {
                            ClaseDatosErrorValidacion datos = new ClaseDatosErrorValidacion();
                            datos.TransaccionPadre = ds.Tables[0].Rows[cont]["transaccionPadre"].ToString();
                            datos.Transaccion = ds.Tables[0].Rows[cont]["transaccion"].ToString();     
                            datos.NombreArchivo = ds.Tables[0].Rows[cont]["nombreArchivo"].ToString();
                            //string[] separadorNombre = datos.NombreArchivo.Split('_');
                            //string nombre = separadorNombre[1];
                            //datos.NombreArchivo = nombre;

                            datos.MensajeError = ds.Tables[0].Rows[cont]["mensajeError"].ToString();
                            //string[] separadorMensaje = new string[] { "Excepcion: " };
                            //var resultMensaje = datos.MensajeError.Split(separadorMensaje, StringSplitOptions.None);
                            //string mensaje = resultMensaje[1].ToString();
                            //datos.MensajeError = mensaje;
                          
                            lista.Add(datos);
                        }
                    }
                }

                return lista;

            }
            catch (Exception e)
            {
                lista = null;
                return lista;
            }
        }



        /**************ENVIA EMAIL ARCHIVOS CARGADOS***********/
        public int EnviarEmailResumenCarga(string correo, string idPadre)
        {
            string correoDe = "";
            string server = "";
            string puerto = "";
            string password = "";
            string cuerpo = "";
            string asunto = "";
            try
            {
                List<ClaseDatosEnvioResumenCarga> listaResumenCarga = new List<ClaseDatosEnvioResumenCarga>();
                listaResumenCarga = ObtenerResumenCarga(idPadre);
                if (listaResumenCarga == null)
                {
                    return 0;
                }
                else
                {
                    correoDe = new AppSettingsReader().GetValue("CorreoDe", typeof(System.String)).ToString();
                    server = new AppSettingsReader().GetValue("Server", typeof(System.String)).ToString();
                    puerto = new AppSettingsReader().GetValue("Puerto", typeof(System.String)).ToString();
                    password = new AppSettingsReader().GetValue("Password", typeof(System.String)).ToString();
                    cuerpo = cuerpoEmailResumenCarga(listaResumenCarga, Convert.ToInt32(idPadre));
                    asunto = asuntoEmailResumenCarga(listaResumenCarga, Convert.ToInt32(idPadre));

                    if (cuerpo == null || cuerpo == "" || asunto == null || asunto == "")
                    {
                        return 0;
                    }
                    else
                    {

                        MailMessage msg = new MailMessage(correo, correoDe, asunto, cuerpo);
                        msg.To.Add(new MailAddress(correo));
                        msg.BodyEncoding = System.Text.Encoding.UTF8;
                        msg.SubjectEncoding = System.Text.Encoding.Default;
                        msg.IsBodyHtml = true;
                        msg.From = new MailAddress(correoDe);
                        msg.Body = cuerpo;
                        SmtpClient smtp = new SmtpClient(server, Convert.ToInt32(puerto))
                        {
                            Credentials = new NetworkCredential(correoDe, password),
                            EnableSsl = true,
                            Host = server,
                            Port = Convert.ToInt32(puerto),


                            Timeout = 20000
                        };
                        smtp.Send(msg);
                        return 1;
                    }
                }
            }
            catch (Exception ex)
            {
                // rg.eLog("Error al eliminar el archivo: " + ex.ToString());
                return 0;

            }
        }

        /**************ARMA CUERPO EMAIL ARCHIVOS CARGADOS***********/
        public string cuerpoEmailResumenCarga(List<ClaseDatosEnvioResumenCarga> listaResumenCarga, int idPadre)
        {
            string TransaccionPadre = "";
            string NRO_IDENT_PART = "";
            string COD_PART = "";
            string cuerpo = "";
            string tipo = "";
            try
            {
              
                if (listaResumenCarga ==null || listaResumenCarga.Count==0)
                {
                    cuerpo = "";
                    return cuerpo;

                }
                else{
                    TransaccionPadre =listaResumenCarga.ElementAt(0).TransaccionPadre;
                    NRO_IDENT_PART= listaResumenCarga.ElementAt(0).NRO_IDENT_PART ;
                    COD_PART=listaResumenCarga.ElementAt(0).COD_PART;
                    TransaccionPadre = listaResumenCarga.ElementAt(0).TransaccionPadre;

                    if (TransaccionPadre == "04012")
                    {
                         tipo= "transferencia contable ";
                    }
                    else
                    {
                        tipo = "anotación en cuenta";
                    }
                    cuerpo = "<!DOCTYPE html PUBLIC " + @"""-//W3C//DTD XHTML 1.0 Transitional//EN""" + @" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" + @"""><html xmlns=" + @"""http://www.w3.org/1999/xhtml" + @""">";
                    //cuerpo = cuerpo + @"<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">";
                    cuerpo = cuerpo + "<html><body><p>Estimado.</p><p>Se ha realizado la ";
                    cuerpo = cuerpo + tipo;
                    cuerpo=cuerpo+" con el número de transacción ";
                    cuerpo = cuerpo + idPadre+ "</p>";    
                    cuerpo = cuerpo + " para el RUC ";
                    cuerpo = cuerpo + NRO_IDENT_PART;
                    cuerpo = cuerpo + " con el código de participante número ";
                    cuerpo = cuerpo + COD_PART;
                    cuerpo = cuerpo + ".</p>";
                    cuerpo = cuerpo + @"<table  style=""border: 1px solid black; padding: 10px;"" class=""table-bordered table-striped""><thead><tr style=""border: 1px solid black; padding: 10px;""><th style=""border: 1px solid black; padding: 10px;""> Nro</th><th style=""border: 1px solid black; padding: 10px;""> Nombre Archivo </th></tr></thead><tbody>";
                    cuerpo = cuerpo +  "<br><br><br>";
                    for (int cont = 0; cont < listaResumenCarga.Count; cont++)
                    {
                    cuerpo = cuerpo + @"<tr style=""border: 1px solid black; padding: 10px;""><td style=""border: 1px solid black; padding: 10px;"">";
                        cuerpo = cuerpo + (cont+1);
                    cuerpo = cuerpo + @"</td><td style=""border: 1px solid black; padding: 10px;"">";
                    cuerpo = cuerpo + listaResumenCarga.ElementAt(cont).NombreArchivo;
                    cuerpo = cuerpo + "</td></tr>";
                }
                    cuerpo = cuerpo + "</tbody></table>";
                    cuerpo = cuerpo + "</body></html>";

                }

                return cuerpo;
            }
            catch (Exception e)
            {
                cuerpo = "";
                return cuerpo;
            }

        }

        /**************ARMA ASUNTO EMAIL ARCHIVOS CARGADOS***********/
        public string asuntoEmailResumenCarga(List<ClaseDatosEnvioResumenCarga> listaResumenCarga, int idPadre)
        {
            string TransaccionPadre = "";
            string asunto = "";
            try
            {

                if (listaResumenCarga == null || listaResumenCarga.Count == 0)
                {
                    asunto = "";
                    return asunto;

                }
                else
                {
                    TransaccionPadre = listaResumenCarga.ElementAt(0).TransaccionPadre;

                    if (TransaccionPadre == "04012")
                    {
                        asunto = "Detalle envío de documentos para una transferencia contable ";
                    }
                    else
                    {
                        asunto = "Detalle envío de documentos para una anotación en cuenta";
                    }

                }

                return asunto;

            }
            catch (Exception e)
            {
                asunto = "";
                return asunto;
            }

        }

        /**************ENVIA EMAIL ERRORES VALIDACION***********/
        public int EnviarEmailErrorValidacion(string correo, string idPadre)
        {
            string correoDe = "";
            string server = "";
            string puerto = "";
            string password = "";
            string cuerpo = "";
            string asunto = "";
            try
            {
                List<ClaseDatosErrorValidacion> listaErrorValidacion = new List<ClaseDatosErrorValidacion>();
                listaErrorValidacion = ObtenerErrorValidacion(idPadre);
                if (listaErrorValidacion == null)
                {
                    return 0;
                }
                else
                {
                    correoDe = new AppSettingsReader().GetValue("CorreoDe", typeof(System.String)).ToString();
                    server = new AppSettingsReader().GetValue("Server", typeof(System.String)).ToString();
                    puerto = new AppSettingsReader().GetValue("Puerto", typeof(System.String)).ToString();
                    password = new AppSettingsReader().GetValue("Password", typeof(System.String)).ToString();
                    cuerpo = cuerpoEmailErrorValidacion(listaErrorValidacion, Convert.ToInt32(idPadre));
                    asunto = asuntoEmailErrorValidacion(listaErrorValidacion, Convert.ToInt32(idPadre));

                    if (cuerpo == null || cuerpo == "" || asunto == null || asunto == "")
                    {
                        return 0;
                    }
                    else
                    {
                        MailMessage msg = new MailMessage(correo, correoDe, asunto, cuerpo);
                        msg.To.Add(new MailAddress(correo));
                        msg.BodyEncoding = System.Text.Encoding.UTF8;
                        msg.SubjectEncoding = System.Text.Encoding.Default;
                        msg.IsBodyHtml = true;
                        msg.From = new MailAddress(correoDe);
                        msg.Body = cuerpo;
                        SmtpClient smtp = new SmtpClient(server, Convert.ToInt32(puerto))
                        {
                            Credentials = new NetworkCredential(correoDe, password),
                            EnableSsl = true,
                            Host = server,
                            Port = Convert.ToInt32(puerto),


                            Timeout = 20000
                        };
                        smtp.Send(msg);
                        return 1;
                    }
                }
            }
            catch (Exception ex)
            {
                // rg.eLog("Error al eliminar el archivo: " + ex.ToString());
                return 0;

            }
        }



        /**************ARMA CUERPO EMAIL ERRORES VALIDACION***********/
        public string cuerpoEmailErrorValidacion(List<ClaseDatosErrorValidacion> listaErrorValidacion, int idPadre)
        {
            string TransaccionPadre = "";
            string cuerpo = "";
            try
            {
               
                if (listaErrorValidacion == null || listaErrorValidacion.Count == 0)
                {
                    
                    cuerpo = "";
                    return cuerpo;

                }
                else
                {
                    TransaccionPadre = listaErrorValidacion.ElementAt(0).TransaccionPadre;
                        cuerpo = "<!DOCTYPE html PUBLIC " + @"""-//W3C//DTD XHTML 1.0 Transitional//EN""" + @" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" + @"""><html xmlns=" + @"""http://www.w3.org/1999/xhtml" + @""">";
                        //cuerpo=cuerpo+ @"<img src=""../Imagenes/logo.png"" width=""150px"" height=""60px""/>";
                        //cuerpo = cuerpo + @"<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">";
                        cuerpo = cuerpo + @"<html><link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"" integrity=""sha384-HSMxcRTRxnN+Bdg0JdbxYKrThecOKuH5zCYotlSAcp1+c8xmyTe9GYg1l9a69psu"" crossorigin=""anonymous"">";
                        cuerpo =cuerpo+"<body><p>Estimado.</p><p>Se han encontrado los siguientes errores para la transacción ";
                        cuerpo = cuerpo + idPadre;
                        cuerpo = cuerpo + ".</p>";
                        cuerpo = cuerpo + "<p>Los documentos con errores se muestran a continuación:</p>";
                        cuerpo = cuerpo + @"<table  style=""border: 1px solid black; padding: 10px;"" class=""table-bordered table-striped""><thead><tr style=""border: 1px solid black; padding: 10px;""><th style=""border: 1px solid black; padding: 10px;""> Nro</th><th style=""border: 1px solid black; padding: 10px;""> Nombre Archivo</th><th style=""border: 1px solid black; padding: 10px;""> Mensaje error </th></tr></thead><tbody>";
                    for (int cont = 0; cont < listaErrorValidacion.Count; cont++)
                    {
                            cuerpo = cuerpo + @"<tr style=""border: 1px solid black; padding: 10px;""><td style=""border: 1px solid black; padding: 10px;"">";
                            cuerpo = cuerpo + (cont + 1);
                            cuerpo = cuerpo + @"</td><td style=""border: 1px solid black; padding: 10px;"">";
                            cuerpo = cuerpo + listaErrorValidacion.ElementAt(cont).NombreArchivo;                        
                            cuerpo = cuerpo + @"</td><td style=""border: 1px solid black; padding: 10px;"">";
                            cuerpo = cuerpo + listaErrorValidacion.ElementAt(cont).MensajeError;
                            cuerpo = cuerpo + "</td></tr>";
                        }
                        cuerpo = cuerpo + "</tbody></table>";
                        cuerpo = cuerpo + "</body></html>";
 
                }
                return cuerpo;

            }
            catch (Exception e)
            {
                cuerpo = "";
                return cuerpo;
            }



        }

        /**************ARMA ASUNTO EMAIL ERRORES VALIDACION***********/
        public string asuntoEmailErrorValidacion(List<ClaseDatosErrorValidacion> listaErrorValidacion, int idPadre)
        {
            string TransaccionPadre = "";
            string asunto = "";
            try
            {

                if (listaErrorValidacion == null || listaErrorValidacion.Count == 0)
                {
                    asunto = "";
                    return asunto;

                }
                else
                {
                    TransaccionPadre = listaErrorValidacion.ElementAt(0).TransaccionPadre;

                    if (TransaccionPadre == "04012")
                    {
                        asunto = "Error en documentos enviados";
                    }
                    else
                    {
                        asunto = "Error en documentos enviados ";

                    }

                }

                return asunto;

            }
            catch (Exception e)
            {
                asunto = "";
                return asunto;
            }

        }

    }
}
