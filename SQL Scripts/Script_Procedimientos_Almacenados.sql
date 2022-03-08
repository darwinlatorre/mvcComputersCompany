-- Storage procedure for available and ocuppied database space -------------------------------------------------------------------------------

create materialized view DBA_DATA_FILES
AS (select * from DBA_DATA_FILES);

create materialized view DBA_FREE_SPACE
AS (select * from DBA_FREE_SPACE);

create or replace procedure prcAlmacenamiento(prmLibreMB out dba_free_space.bytes%type, prmOcupadoMB out dba_data_files.bytes%type)
is
begin
    select "Espacio Libre (MB)", "Espacio Reservado (MB)" - "Espacio Libre (MB)" "Espacio Ocupado (MB)" into prmLibreMB, prmOcupadoMB
    from(select (select sum((bytes/(1014*1024))*0.990235) from dba_data_files) "Espacio Reservado (MB)",
        (select sum((bytes/(1014*1024))*0.990235) from dba_free_space) "Espacio Libre (MB)"
        from dual);
end prcAlmacenamiento;

create public synonym prcAlmacenamiento for PRCALMACENAMIENTO;

----------------------------------------------------------------------------------------------------------------------------------------------

-- Storage procedure for actual user restrictions --------------------------------------------------------------------------------------------

create or replace procedure prcRestriccionesUsuarioActual(crRestricciones in out sys_refcursor)
IS
BEGIN
    OPEN crRestricciones for
    select constraint_name "Nombre", constraint_type "Tipo", table_name "Tabla", search_condition_vc "Condicion", status "Estado"
    from USER_CONSTRAINTS
    order by constraint_name;
END prcRestriccionesUsuarioActual;

create public synonym prcRestriccionesUsuarioActual for PRCRESTRICCIONESUSUARIOACTUAL;

----------------------------------------------------------------------------------------------------------------------------------------------