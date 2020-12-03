using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ClaseDatos;
using System.Net.Mail;
using System.Net.Mime;
using System.Configuration;
using System.Net;
using dim.rutinas;



namespace WS_Notificaciones_Web_Cliente
{
    /// <summary>
    /// Descripción breve de WS_Notificaciones_Web_Cliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
   public class WS_Notificaciones_Web_Cliente : System.Web.Services.WebService
    {

        [WebMethod(Description = "Envio_Resumen_Carga")]
        public ClaseEntradaSalida.MENSAJERES_Type Envio_Resumen_Carga(ClaseEntradaSalida.CABECERA_Type cabecera, ClaseEntradaSalida.DATOS_Type datosWC)

        {
            /****** DECLARAR TIPO DE DATOS PARA RESPUESTA********/
            ClaseEntradaSalida.MENSAJERES_Type MENSAJERES = new ClaseEntradaSalida.MENSAJERES_Type();
            ClaseEntradaSalida.INTEGRACIONRES_Type INTEGRES = new ClaseEntradaSalida.INTEGRACIONRES_Type();
            ClaseEntradaSalida.CABECERARes_Type CABECERA = new ClaseEntradaSalida.CABECERARes_Type();
            ClaseEntradaSalida.DETALLERes_Type DETALLE = new ClaseEntradaSalida.DETALLERes_Type();
            ClaseEntradaSalida.DATOSRes_Type DATOS = new ClaseEntradaSalida.DATOSRes_Type();
            string idPadre = "";
            string appConsumidora = "";
            RutinasGenerales rg = new RutinasGenerales();
            ClaseDatosTRAN_PADRE datosTP = new ClaseDatosTRAN_PADRE();
            ClaseTRAN_PADRE datosTRAN_PADRE = new ClaseTRAN_PADRE();

            int enviado = 0;
            /***RESPUESTA DEFAULT EN CASO DE QUE LA EJECUCION SEA ERRONEA***/
            CABECERA.APP_CONSUMIDORA = "WS_Notificaciones";
            CABECERA.COD_RESPUESTA = "0";
            CABECERA.DES_RESPUESTA = "Ejecución Erronea";
            DATOS.resultCode = null;
            DATOS.message = null;
            DETALLE.DATOS = DATOS;
            INTEGRES.CABECERA = CABECERA;
            INTEGRES.DETALLE = DETALLE;
            MENSAJERES.INTEGRES = INTEGRES;


            try
            {

                /****VALIDACIONES DATOS ENTRADA****/
                if (cabecera != null)
                {
                   
                    if (cabecera.APP_CONSUMIDORA == null || cabecera.APP_CONSUMIDORA == "")
                    {
                        
                        CABECERA.APP_CONSUMIDORA = "WS_Notificaciones";
                        CABECERA.COD_RESPUESTA = "0";
                        CABECERA.DES_RESPUESTA = "Ejecución Erronea";
                        DATOS.resultCode = "0";
                        DATOS.message = "Debe ingresar el nombre de la Aplicación consumidora";
                        DETALLE.DATOS = DATOS;
                        INTEGRES.CABECERA = CABECERA;
                        INTEGRES.DETALLE = DETALLE;
                        MENSAJERES.INTEGRES = INTEGRES;
                      
                        return MENSAJERES;
                    }
                    else
                    {
                        if (cabecera.APP_CONSUMIDORA.Length > 50)
                        {                   
                            CABECERA.APP_CONSUMIDORA = cabecera.APP_CONSUMIDORA;
                            CABECERA.COD_RESPUESTA = "0";
                            CABECERA.DES_RESPUESTA = "Ejecución Erronea";
                            DATOS.resultCode = "0";
                            DATOS.message = "El nombre de la Aplicación consumidora no debe exceder los 50 caracteres";
                            DETALLE.DATOS = DATOS;
                            INTEGRES.CABECERA = CABECERA;
                            INTEGRES.DETALLE = DETALLE;
                            MENSAJERES.INTEGRES = INTEGRES;

                            return MENSAJERES;

                        }
                        else
                        {
                            appConsumidora = cabecera.APP_CONSUMIDORA.ToString().ToUpper();
                        }

                    }
                }
                else
                {
                    CABECERA.APP_CONSUMIDORA = "WS_Notificaciones";
                    CABECERA.COD_RESPUESTA = "0";
                    CABECERA.DES_RESPUESTA = "Ejecución Erronea";
                    DATOS.resultCode = "0";
                    DATOS.message = "Debe completar los campos obligatorios";
                    DETALLE.DATOS = DATOS;
                    INTEGRES.CABECERA = CABECERA;
                    INTEGRES.DETALLE = DETALLE;
                    MENSAJERES.INTEGRES = INTEGRES;
                    return MENSAJERES;


                }

                if (datosWC != null)
                {

                    if (datosWC.idPadre == null || datosWC.idPadre == "")
                    {

                        CABECERA.APP_CONSUMIDORA = cabecera.APP_CONSUMIDORA;
                        CABECERA.COD_RESPUESTA = "0";
                        CABECERA.DES_RESPUESTA = "Ejecución Erronea";
                        DATOS.resultCode = "0";
                        DATOS.message = "Debe ingresar el idPadre";
                        DETALLE.DATOS = DATOS;
                        INTEGRES.CABECERA = CABECERA;
                        INTEGRES.DETALLE = DETALLE;
                        MENSAJERES.INTEGRES = INTEGRES;

                        return MENSAJERES;
                    }
                    else
                    {

                        if (rg.IsNumeric(datosWC.idPadre))
                        {
                            if (datosWC.idPadre.Length > 11)
                            {
                                CABECERA.APP_CONSUMIDORA = cabecera.APP_CONSUMIDORA;
                                CABECERA.COD_RESPUESTA = "0";
                                CABECERA.DES_RESPUESTA = "Ejecución Erronea";
                                DATOS.resultCode = "0";
                                DATOS.message = "El idPadre no debe exceder los 50 digitos";
                                DETALLE.DATOS = DATOS;
                                INTEGRES.CABECERA = CABECERA;
                                INTEGRES.DETALLE = DETALLE;
                                MENSAJERES.INTEGRES = INTEGRES;

                                return MENSAJERES;

                            }
                            else
                            {
                                idPadre = datosWC.idPadre;
                            }
                        }
                        else
                        {
                            CABECERA.APP_CONSUMIDORA = cabecera.APP_CONSUMIDORA;
                            CABECERA.COD_RESPUESTA = "0";
                            CABECERA.DES_RESPUESTA = "Ejecución Erronea";
                            DATOS.resultCode = "0";
                            DATOS.message = "El idPadre ingresado no es válido,debe ser un numero";
                            DETALLE.DATOS = DATOS;
                            INTEGRES.CABECERA = CABECERA;
                            INTEGRES.DETALLE = DETALLE;
                            MENSAJERES.INTEGRES = INTEGRES;

                            return MENSAJERES;
                        }
                    
                    }
                }
                else
                {
                    CABECERA.APP_CONSUMIDORA = cabecera.APP_CONSUMIDORA;
                    CABECERA.COD_RESPUESTA = "0";
                    CABECERA.DES_RESPUESTA = "Ejecución Erronea";
                    DATOS.resultCode = "0";
                    DATOS.message = "Debe completar los campos obligatorios";
                    DETALLE.DATOS = DATOS;
                    INTEGRES.CABECERA = CABECERA;
                    INTEGRES.DETALLE = DETALLE;
                    MENSAJERES.INTEGRES = INTEGRES;
                    return MENSAJERES;

                }




                /****BUSCAR EMAIL CON EL IDPADRE****/
                if (idPadre != "" && idPadre != null)
                {
                    try
                    {
                        try
                        {
                            datosTP = datosTRAN_PADRE.ObtenerDatosIdPadre(idPadre);
                        }
                        catch (Exception ex)
                        {
                            return MENSAJERES;
                        }

                        if (datosTP.TRAN_PADRE_ORIGEN != "" && datosTP.TRAN_PADRE_ORIGEN != null && datosTP.TRAN_PADRE_EMAIL != "" && datosTP.TRAN_PADRE_EMAIL != null)

                        {
                            try
                            {

                                enviado = datosTRAN_PADRE.EnviarEmailResumenCarga(datosTP.TRAN_PADRE_EMAIL, idPadre);
                            }
                            catch (Exception ex)
                            {
                                return MENSAJERES;
                            }

                            if (enviado == 1)
                            {
                                //SI EL EMAIL SE ENVIO CORRECTAMENTE, SE ENVIA RESPUESTA CORRECTA
                                CABECERA.APP_CONSUMIDORA = appConsumidora;
                                CABECERA.COD_RESPUESTA = "1";
                                CABECERA.DES_RESPUESTA = "Ejecución Correcta";
                                DATOS.resultCode = "1";
                                DATOS.message = "Email Enviado";
                                DETALLE.DATOS = DATOS;
                                INTEGRES.CABECERA = CABECERA;
                                INTEGRES.DETALLE = DETALLE;
                                MENSAJERES.INTEGRES = INTEGRES;
                            }
                            else
                            {
                                //SI EL EMAIL NO SE ENVIO, SE ENVIA RESPUESTA ERRONEA
                                CABECERA.APP_CONSUMIDORA = appConsumidora;
                                CABECERA.COD_RESPUESTA = "1";
                                CABECERA.DES_RESPUESTA = "Ejecución Correcta";
                                DATOS.resultCode = "0";
                                DATOS.message = "Email No Enviado";
                                DETALLE.DATOS = DATOS;
                                INTEGRES.CABECERA = CABECERA;
                                INTEGRES.DETALLE = DETALLE;
                                MENSAJERES.INTEGRES = INTEGRES;

                            }
                        }
                        else
                        {
                            return MENSAJERES;
                        }

                    }
                    catch (Exception ex)
                    {
                        return MENSAJERES;
                    }
                }
                else
                {
                    return MENSAJERES;

                }
                return MENSAJERES;
            }
            catch(Exception ex)
            {
                return MENSAJERES;
            }
        }



        [WebMethod(Description = "Error_Validacion")]
        public ClaseEntradaSalida.MENSAJERES_Type Error_Validacion(ClaseEntradaSalida.CABECERA_Type cabecera, ClaseEntradaSalida.DATOS_Type datosWC)

        {
            /****** DECLARAR TIPO DE DATOS PARA RESPUESTA********/
            ClaseEntradaSalida.MENSAJERES_Type MENSAJERES = new ClaseEntradaSalida.MENSAJERES_Type();
            ClaseEntradaSalida.INTEGRACIONRES_Type INTEGRES = new ClaseEntradaSalida.INTEGRACIONRES_Type();
            ClaseEntradaSalida.CABECERARes_Type CABECERA = new ClaseEntradaSalida.CABECERARes_Type();
            ClaseEntradaSalida.DETALLERes_Type DETALLE = new ClaseEntradaSalida.DETALLERes_Type();
            ClaseEntradaSalida.DATOSRes_Type DATOS = new ClaseEntradaSalida.DATOSRes_Type();
            RutinasGenerales rg = new RutinasGenerales();
            string idPadre = "";
            string appConsumidora = "";
            ClaseDatosTRAN_PADRE datosTP = new ClaseDatosTRAN_PADRE();
            ClaseTRAN_PADRE datosTRAN_PADRE = new ClaseTRAN_PADRE();


            int enviado = 0;
            /***RESPUESTA DEFAULT EN CASO DE QUE LA EJECUCION SEA ERRONEA***/
            CABECERA.APP_CONSUMIDORA = "WS_Notificaciones";
            CABECERA.COD_RESPUESTA = "0";
            CABECERA.DES_RESPUESTA = "Ejecución Erronea";
            DATOS.resultCode = null;
            DATOS.message = null;
            DETALLE.DATOS = DATOS;
            INTEGRES.CABECERA = CABECERA;
            INTEGRES.DETALLE = DETALLE;
            MENSAJERES.INTEGRES = INTEGRES;

            try
            {


                /****VALIDACIONES DATOS ENTRADA****/
                if (cabecera != null)
                {

                    if (cabecera.APP_CONSUMIDORA == null || cabecera.APP_CONSUMIDORA == "")
                    {

                        CABECERA.APP_CONSUMIDORA = "WS_Notificaciones";
                        CABECERA.COD_RESPUESTA = "0";
                        CABECERA.DES_RESPUESTA = "Ejecución Erronea";
                        DATOS.resultCode = "0";
                        DATOS.message = "Debe ingresar el nombre de la Aplicación consumidora";
                        DETALLE.DATOS = DATOS;
                        INTEGRES.CABECERA = CABECERA;
                        INTEGRES.DETALLE = DETALLE;
                        MENSAJERES.INTEGRES = INTEGRES;

                        return MENSAJERES;
                    }
                    else
                    {
                        if (cabecera.APP_CONSUMIDORA.Length > 50)
                        {
                            CABECERA.APP_CONSUMIDORA = cabecera.APP_CONSUMIDORA;
                            CABECERA.COD_RESPUESTA = "0";
                            CABECERA.DES_RESPUESTA = "Ejecución Erronea";
                            DATOS.resultCode = "0";
                            DATOS.message = "El nombre de la Aplicación consumidora no debe exceder los 50 caracteres";
                            DETALLE.DATOS = DATOS;
                            INTEGRES.CABECERA = CABECERA;
                            INTEGRES.DETALLE = DETALLE;
                            MENSAJERES.INTEGRES = INTEGRES;

                            return MENSAJERES;

                        }
                        else
                        {
                            appConsumidora = cabecera.APP_CONSUMIDORA.ToString().ToUpper();
                        }

                    }
                }
                else
                {
                    CABECERA.APP_CONSUMIDORA = "WS_Notificaciones";
                    CABECERA.COD_RESPUESTA = "0";
                    CABECERA.DES_RESPUESTA = "Ejecución Erronea";
                    DATOS.resultCode = "0";
                    DATOS.message = "Debe completar los campos obligatorios";
                    DETALLE.DATOS = DATOS;
                    INTEGRES.CABECERA = CABECERA;
                    INTEGRES.DETALLE = DETALLE;
                    MENSAJERES.INTEGRES = INTEGRES;
                    return MENSAJERES;


                }

                if (datosWC != null)
                {

                    if (datosWC.idPadre == null || datosWC.idPadre == "")
                    {

                        CABECERA.APP_CONSUMIDORA = cabecera.APP_CONSUMIDORA;
                        CABECERA.COD_RESPUESTA = "0";
                        CABECERA.DES_RESPUESTA = "Ejecución Erronea";
                        DATOS.resultCode = "0";
                        DATOS.message = "Debe ingresar el idPadre";
                        DETALLE.DATOS = DATOS;
                        INTEGRES.CABECERA = CABECERA;
                        INTEGRES.DETALLE = DETALLE;
                        MENSAJERES.INTEGRES = INTEGRES;

                        return MENSAJERES;
                    }
                    else
                    {

                        if (rg.IsNumeric(datosWC.idPadre))
                        {
                            if (datosWC.idPadre.Length > 11)
                            {
                                CABECERA.APP_CONSUMIDORA = cabecera.APP_CONSUMIDORA;
                                CABECERA.COD_RESPUESTA = "0";
                                CABECERA.DES_RESPUESTA = "Ejecución Erronea";
                                DATOS.resultCode = "0";
                                DATOS.message = "El idPadre no debe exceder los 50 digitos";
                                DETALLE.DATOS = DATOS;
                                INTEGRES.CABECERA = CABECERA;
                                INTEGRES.DETALLE = DETALLE;
                                MENSAJERES.INTEGRES = INTEGRES;

                                return MENSAJERES;

                            }
                            else
                            {
                                idPadre = datosWC.idPadre;
                            }
                        }
                        else
                        {
                            CABECERA.APP_CONSUMIDORA = cabecera.APP_CONSUMIDORA;
                            CABECERA.COD_RESPUESTA = "0";
                            CABECERA.DES_RESPUESTA = "Ejecución Erronea";
                            DATOS.resultCode = "0";
                            DATOS.message = "El idPadre ingresado no es válido, debe ser un numero";
                            DETALLE.DATOS = DATOS;
                            INTEGRES.CABECERA = CABECERA;
                            INTEGRES.DETALLE = DETALLE;
                            MENSAJERES.INTEGRES = INTEGRES;

                            return MENSAJERES;
                        }

                    }
                }
                else
                {
                    CABECERA.APP_CONSUMIDORA = cabecera.APP_CONSUMIDORA;
                    CABECERA.COD_RESPUESTA = "0";
                    CABECERA.DES_RESPUESTA = "Ejecución Erronea";
                    DATOS.resultCode = "0";
                    DATOS.message = "Debe completar los campos obligatorios";
                    DETALLE.DATOS = DATOS;
                    INTEGRES.CABECERA = CABECERA;
                    INTEGRES.DETALLE = DETALLE;
                    MENSAJERES.INTEGRES = INTEGRES;
                    return MENSAJERES;


                }


                //BUSCAR EMAIL CON EL IDPADRE
                if (idPadre != "" && idPadre != null)
                {
                    try
                    {
                        try
                        {
                            datosTP = datosTRAN_PADRE.ObtenerDatosIdPadre(idPadre);
                        }
                        catch (Exception ex)
                        {
                            return MENSAJERES;
                        }

                        if (datosTP.TRAN_PADRE_ORIGEN != "" && datosTP.TRAN_PADRE_ORIGEN != null && datosTP.TRAN_PADRE_EMAIL != "" && datosTP.TRAN_PADRE_EMAIL != null)

                        {
                            try
                            {

                                enviado = datosTRAN_PADRE.EnviarEmailErrorValidacion(datosTP.TRAN_PADRE_EMAIL, idPadre);
                            }
                            catch (Exception ex)
                            {
                                return MENSAJERES;
                            }

                            if (enviado == 1)
                            {
                                //SI EL EMAIL SE ENVIO CORRECTAMENTE, SE ENVIA RESPUESTA CORRECTA
                                CABECERA.APP_CONSUMIDORA = appConsumidora;
                                CABECERA.COD_RESPUESTA = "1";
                                CABECERA.DES_RESPUESTA = "Ejecución Correcta";
                                DATOS.resultCode = "1";
                                DATOS.message = "Email Enviado";
                                DETALLE.DATOS = DATOS;
                                INTEGRES.CABECERA = CABECERA;
                                INTEGRES.DETALLE = DETALLE;
                                MENSAJERES.INTEGRES = INTEGRES;
                            }
                            else
                            {
                                //SI EL EMAIL NO SE ENVIO, SE ENVIA RESPUESTA ERRONEA
                                CABECERA.APP_CONSUMIDORA = appConsumidora;
                                CABECERA.COD_RESPUESTA = "1";
                                CABECERA.DES_RESPUESTA = "Ejecución Correcta";
                                DATOS.resultCode = "0";
                                DATOS.message = "Email No Enviado";
                                DETALLE.DATOS = DATOS;
                                INTEGRES.CABECERA = CABECERA;
                                INTEGRES.DETALLE = DETALLE;
                                MENSAJERES.INTEGRES = INTEGRES;
                            }
                        }
                        else
                        {
                            return MENSAJERES;
                        }

                    }
                    catch (Exception ex)
                    {
                        return MENSAJERES;
                    }
                }
                else
                {
                    return MENSAJERES;

                }
                return MENSAJERES;
            }catch(Exception ex)
            {
                return MENSAJERES;
            }
        }


    }
}
