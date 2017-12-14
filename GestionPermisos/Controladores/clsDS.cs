using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPermisos.Controladores
{
    public static class clsDS
    {

        //Dataset estaticos
        private static DataSet ds_perfiles;
        private static DataSet ds_usuarios;
        private static DataSet ds_unidades;
        private static DataSet ds_permisos;
        private static DataSet ds_resoluciones;
        private static DataSet ds_tipos_permisos;
        private static DataSet ds_permisos_detalle;
        private static DataSet ds_resoluciones_detalle;

        //Queries de los dataset
        public static string sSQL_PERFILES = "SELECT * FROM PERFILES";
        public static string sSQL_USUARIOS = "SELECT * FROM USUARIOS";
        public static string sSQL_UNIDADES = "SELECT * FROM UNIDADES";
        public static string sSQL_PERMISOS = "SELECT " +
                                             "permisos.*, " +
                                             "permisos_detalles.id_detalle_permiso, " +
                                             "permisos_detalles.fechaemision, " +
                                             "permisos_detalles.estado, " +
                                             "permisos_detalles.fechainicio, " +
                                             "permisos_detalles.fechafin, " +
                                             "permisos_detalles.dias, " +
                                             "permisos_detalles.usuarios_id_usuario AS usuarios_id_usuario1, " +
                                             "permisos_detalles.motivo, " +
                                             "tipos_permisos.detallepermiso, " +
                                             "tipos_permisos.diasafectos, " +
                                             "tipos_permisos.eliminado " +
                                             "FROM " +
                                             "permisos " +
                                             "LEFT JOIN permisos_detalles ON permisos.id_permiso = permisos_detalles.permisos_id_permiso " +
                                             "INNER JOIN tipos_permisos ON tipos_permisos.id_tipo_permiso = permisos.id_tipo_permiso " +
                                             "ORDER BY permisos_detalles.fechaemision desc";
        public static string sSQL_RESOLUCIONES = "SELECT * FROM RESOLUCIONES";
        public static string sSQL_TIPOS_PERMISOS = "SELECT * FROM TIPOS_PERMISOS";
        public static string sSQL_PERMISOS_DETALLES = "SELECT * FROM PERMISOS_DET";
        public static string sSQL_RESOLUCIONES_DETALLES = "SELECT " +
    "usuarios.rut, " +
    "resoluciones_detalle.*, " +
    "permisos_detalles.fechaemision AS fechaemision1, " +
    "permisos_detalles.estado, " +
    "permisos_detalles.fechainicio, " +
    "permisos_detalles.fechafin, " +
    "permisos_detalles.dias, " +
    "permisos_detalles.motivo, " +
    "tipos_permisos.detallepermiso " +
"FROM " +
    "resoluciones_detalle " +
    "INNER JOIN permisos ON permisos.id_permiso = resoluciones_detalle.permisos_id_permiso " +
    "INNER JOIN usuarios ON usuarios.id_usuario = permisos.usuarios_id_usuario " +
    "INNER JOIN permisos_detalles ON " +
        "permisos.id_permiso = permisos_detalles.permisos_id_permiso " +
    "AND " +
        "usuarios.id_usuario = permisos_detalles.usuarios_id_usuario " +
    "INNER JOIN tipos_permisos ON tipos_permisos.id_tipo_permiso = permisos.id_tipo_permiso";

        //Accesadores y mutadores
        public static DataSet DS_PERFILES { get => ds_perfiles; set => ds_perfiles = value; }
        public static DataSet DS_USUARIOS { get => ds_usuarios; set => ds_usuarios = value; }
        public static DataSet DS_UNIDADES { get => ds_unidades; set => ds_unidades = value; }
        public static DataSet DS_PERMISOS { get => ds_permisos; set => ds_permisos = value; }
        public static DataSet DS_RESOLUCIONES { get => ds_resoluciones; set => ds_resoluciones = value; }
        public static DataSet DS_TIPOS_PERMISOS { get => ds_tipos_permisos; set => ds_tipos_permisos = value; }
        public static DataSet DS_PERMISOS_DETALLE { get => ds_permisos_detalle; set => ds_permisos_detalle = value; }
        public static DataSet DS_RESOLUCIONES_DETALLE { get => ds_resoluciones_detalle; set => ds_resoluciones_detalle = value; }

        //Enum para distinguir entre los Dataset
        public enum DATASETSQL
        {
            Perfiles,
            Usuarios,
            Unidades,
            Permisos,
            Resoluciones,
            Tipos_Permisos,
            Permisos_Detalle,
            Resoluciones_Detalle
        };
    }
}
