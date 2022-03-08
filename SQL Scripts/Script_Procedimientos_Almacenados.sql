-- Storage procedure for reserved and available database storage
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
-----------------------------------------------------------------------

