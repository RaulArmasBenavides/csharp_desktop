﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace appcongreso.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class bdcongresoEntities : DbContext
    {
        public bdcongresoEntities()
            : base("name=bdcongresoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<actividades> actividades { get; set; }
        public virtual DbSet<asistencias> asistencias { get; set; }
        public virtual DbSet<Equipo> Equipo { get; set; }
        public virtual DbSet<listaequipos> listaequipos { get; set; }
        public virtual DbSet<participantes> participantes { get; set; }
        public virtual DbSet<sala> sala { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<usp_actividades_listar_all_Result> usp_actividades_listar_all()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_actividades_listar_all_Result>("usp_actividades_listar_all");
        }
    
        public virtual int usp_actualiza_participante(string ap_paterno, string ap_materno, string nombre, string telefono, string sexo, string correo, string dNI, string dirrecion, string tipo)
        {
            var ap_paternoParameter = ap_paterno != null ?
                new ObjectParameter("ap_paterno", ap_paterno) :
                new ObjectParameter("ap_paterno", typeof(string));
    
            var ap_maternoParameter = ap_materno != null ?
                new ObjectParameter("ap_materno", ap_materno) :
                new ObjectParameter("ap_materno", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("sexo", sexo) :
                new ObjectParameter("sexo", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var dNIParameter = dNI != null ?
                new ObjectParameter("DNI", dNI) :
                new ObjectParameter("DNI", typeof(string));
    
            var dirrecionParameter = dirrecion != null ?
                new ObjectParameter("dirrecion", dirrecion) :
                new ObjectParameter("dirrecion", typeof(string));
    
            var tipoParameter = tipo != null ?
                new ObjectParameter("tipo", tipo) :
                new ObjectParameter("tipo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_actualiza_participante", ap_paternoParameter, ap_maternoParameter, nombreParameter, telefonoParameter, sexoParameter, correoParameter, dNIParameter, dirrecionParameter, tipoParameter);
        }
    
        public virtual int usp_actualizar_actividad(Nullable<int> id, string descripcion, Nullable<System.DateTime> fecha)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_actualizar_actividad", idParameter, descripcionParameter, fechaParameter);
        }
    
        public virtual int usp_actualizar_usuario(string usuario, string clave)
        {
            var usuarioParameter = usuario != null ?
                new ObjectParameter("usuario", usuario) :
                new ObjectParameter("usuario", typeof(string));
    
            var claveParameter = clave != null ?
                new ObjectParameter("clave", clave) :
                new ObjectParameter("clave", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_actualizar_usuario", usuarioParameter, claveParameter);
        }
    
        public virtual ObjectResult<usp_BusquedaActividadforDescripcion_Result> usp_BusquedaActividadforDescripcion(string descripcion)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_BusquedaActividadforDescripcion_Result>("usp_BusquedaActividadforDescripcion", descripcionParameter);
        }
    
        public virtual ObjectResult<usp_BusquedaActividadforFecha_Result> usp_BusquedaActividadforFecha(Nullable<System.DateTime> fec1)
        {
            var fec1Parameter = fec1.HasValue ?
                new ObjectParameter("fec1", fec1) :
                new ObjectParameter("fec1", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_BusquedaActividadforFecha_Result>("usp_BusquedaActividadforFecha", fec1Parameter);
        }
    
        public virtual int usp_eliminar_actividad(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_eliminar_actividad", idParameter);
        }
    
        public virtual int usp_eliminar_participante(string dNI)
        {
            var dNIParameter = dNI != null ?
                new ObjectParameter("DNI", dNI) :
                new ObjectParameter("DNI", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_eliminar_participante", dNIParameter);
        }
    
        public virtual int usp_eliminar_usuario(string idusuario)
        {
            var idusuarioParameter = idusuario != null ?
                new ObjectParameter("idusuario", idusuario) :
                new ObjectParameter("idusuario", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_eliminar_usuario", idusuarioParameter);
        }
    
        public virtual ObjectResult<usp_participantes_listar_all_Result> usp_participantes_listar_all()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_participantes_listar_all_Result>("usp_participantes_listar_all");
        }
    
        public virtual ObjectResult<usp_participantes_listar_estudiantes_Result> usp_participantes_listar_estudiantes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_participantes_listar_estudiantes_Result>("usp_participantes_listar_estudiantes");
        }
    
        public virtual ObjectResult<usp_participantes_listar_ponentes_Result> usp_participantes_listar_ponentes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_participantes_listar_ponentes_Result>("usp_participantes_listar_ponentes");
        }
    
        public virtual ObjectResult<usp_participantes_listar_profesionales_Result> usp_participantes_listar_profesionales()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_participantes_listar_profesionales_Result>("usp_participantes_listar_profesionales");
        }
    
        public virtual int usp_registrar_actividad(string descripcion, string rol_creacion, Nullable<int> idasistencias, Nullable<int> idlistaeq, Nullable<int> idsala)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var rol_creacionParameter = rol_creacion != null ?
                new ObjectParameter("rol_creacion", rol_creacion) :
                new ObjectParameter("rol_creacion", typeof(string));
    
            var idasistenciasParameter = idasistencias.HasValue ?
                new ObjectParameter("idasistencias", idasistencias) :
                new ObjectParameter("idasistencias", typeof(int));
    
            var idlistaeqParameter = idlistaeq.HasValue ?
                new ObjectParameter("idlistaeq", idlistaeq) :
                new ObjectParameter("idlistaeq", typeof(int));
    
            var idsalaParameter = idsala.HasValue ?
                new ObjectParameter("idsala", idsala) :
                new ObjectParameter("idsala", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_registrar_actividad", descripcionParameter, rol_creacionParameter, idasistenciasParameter, idlistaeqParameter, idsalaParameter);
        }
    
        public virtual int usp_registrar_Equipo(string nombre, string sO, string procesador, string rAM, string tMADRE)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var sOParameter = sO != null ?
                new ObjectParameter("SO", sO) :
                new ObjectParameter("SO", typeof(string));
    
            var procesadorParameter = procesador != null ?
                new ObjectParameter("Procesador", procesador) :
                new ObjectParameter("Procesador", typeof(string));
    
            var rAMParameter = rAM != null ?
                new ObjectParameter("RAM", rAM) :
                new ObjectParameter("RAM", typeof(string));
    
            var tMADREParameter = tMADRE != null ?
                new ObjectParameter("TMADRE", tMADRE) :
                new ObjectParameter("TMADRE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_registrar_Equipo", nombreParameter, sOParameter, procesadorParameter, rAMParameter, tMADREParameter);
        }
    
        public virtual int usp_registrar_participante(string ap_paterno, string ap_materno, string nombre, string telefono, string sexo, string correo, string dNI, string carrera, string direccion, string tipo)
        {
            var ap_paternoParameter = ap_paterno != null ?
                new ObjectParameter("ap_paterno", ap_paterno) :
                new ObjectParameter("ap_paterno", typeof(string));
    
            var ap_maternoParameter = ap_materno != null ?
                new ObjectParameter("ap_materno", ap_materno) :
                new ObjectParameter("ap_materno", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("sexo", sexo) :
                new ObjectParameter("sexo", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var dNIParameter = dNI != null ?
                new ObjectParameter("DNI", dNI) :
                new ObjectParameter("DNI", typeof(string));
    
            var carreraParameter = carrera != null ?
                new ObjectParameter("carrera", carrera) :
                new ObjectParameter("carrera", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("direccion", direccion) :
                new ObjectParameter("direccion", typeof(string));
    
            var tipoParameter = tipo != null ?
                new ObjectParameter("tipo", tipo) :
                new ObjectParameter("tipo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_registrar_participante", ap_paternoParameter, ap_maternoParameter, nombreParameter, telefonoParameter, sexoParameter, correoParameter, dNIParameter, carreraParameter, direccionParameter, tipoParameter);
        }
    
        public virtual int usp_registrar_usuario(string usuario, string clave)
        {
            var usuarioParameter = usuario != null ?
                new ObjectParameter("usuario", usuario) :
                new ObjectParameter("usuario", typeof(string));
    
            var claveParameter = clave != null ?
                new ObjectParameter("clave", clave) :
                new ObjectParameter("clave", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_registrar_usuario", usuarioParameter, claveParameter);
        }
    
        public virtual ObjectResult<usp_usuarios_listar_all_Result> usp_usuarios_listar_all()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_usuarios_listar_all_Result>("usp_usuarios_listar_all");
        }
    
        public virtual ObjectResult<usp_ValidaUsuario_Result> usp_ValidaUsuario(string usuario, string clave)
        {
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var claveParameter = clave != null ?
                new ObjectParameter("Clave", clave) :
                new ObjectParameter("Clave", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ValidaUsuario_Result>("usp_ValidaUsuario", usuarioParameter, claveParameter);
        }
    
        public virtual int usp_registrar_sala(string nombre, string ubicacion, Nullable<int> capacidad, string rol_creacion)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var ubicacionParameter = ubicacion != null ?
                new ObjectParameter("ubicacion", ubicacion) :
                new ObjectParameter("ubicacion", typeof(string));
    
            var capacidadParameter = capacidad.HasValue ?
                new ObjectParameter("capacidad", capacidad) :
                new ObjectParameter("capacidad", typeof(int));
    
            var rol_creacionParameter = rol_creacion != null ?
                new ObjectParameter("rol_creacion", rol_creacion) :
                new ObjectParameter("rol_creacion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_registrar_sala", nombreParameter, ubicacionParameter, capacidadParameter, rol_creacionParameter);
        }
    
        public virtual ObjectResult<usp_salas_listar_all_Result> usp_salas_listar_all()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_salas_listar_all_Result>("usp_salas_listar_all");
        }
    }
}
