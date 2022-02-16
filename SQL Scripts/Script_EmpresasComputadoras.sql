/*==============================================================*/
/* Table: COMPUTADOR                                            */
/*==============================================================*/
create table COMPUTADOR 
(
   COM_NRO_SERIAL       VARCHAR2(20)         not null,
   EM_NIT               NUMBER(15)           not null,
   COM_MARCA            VARCHAR2(10)         not null
      constraint CKC_COM_MARCA_COMPUTAD check (COM_MARCA in ('Lenovo','Dell','Asus')),
   COM_CAP_DISCO_DURO_GB NUMBER               not null,
   COM_TIPO_DISCO_DURO  VARCHAR2(20)         not null,
   COM_CAP_MEMORIA_RAM_GB NUMBER               not null,
   COM_FECHA_ENSAMBLE   DATE                 not null,
   constraint PK_COMPUTADOR primary key (COM_NRO_SERIAL)
);

/*==============================================================*/
/* Index: REGISTRA_FK                                           */
/*==============================================================*/
create index REGISTRA_FK on COMPUTADOR (
   EM_NIT ASC
);

/*==============================================================*/
/* Table: EMPRESA                                               */
/*==============================================================*/
create table EMPRESA 
(
   EM_NIT               NUMBER(15)           not null,
   EM_NOMBRE            VARCHAR2(40)         not null,
   EM_FECHA_CREACION    DATE                 not null,
   constraint PK_EMPRESA primary key (EM_NIT)
);

alter table COMPUTADOR
   add constraint FK_COMPUTAD_REGISTRA_EMPRESA foreign key (EM_NIT)
      references EMPRESA (EM_NIT);

