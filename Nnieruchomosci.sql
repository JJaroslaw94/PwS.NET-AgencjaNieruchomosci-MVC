/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     30.01.2019 12:54:39                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LISTING_IMG') and o.name = 'FK_LISTING__RELATIONS_LISTING')
alter table LISTING_IMG
   drop constraint FK_LISTING__RELATIONS_LISTING
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LISTING')
            and   type = 'U')
   drop table LISTING
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LISTING_IMG')
            and   name  = 'RELATIONSHIP_1_FK'
            and   indid > 0
            and   indid < 255)
   drop index LISTING_IMG.RELATIONSHIP_1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LISTING_IMG')
            and   type = 'U')
   drop table LISTING_IMG
go

/*==============================================================*/
/* Table: LISTING                                               */
/*==============================================================*/
create table LISTING (
   LISTING_ID           int                  not null,
   HLCN                 varchar(50)          null,
   HOUSE_PRICE          numeric(25)          null,
   BATHROOMS            numeric(5)           null,
   BEDROOMS             numeric(5)           null,
   HOME_LOCATION        varchar(50)          null,
   CONTACT_NAME         varchar(50)          null,
   E_MAIL_CONTACT       varchar(50)          null,
   PHONE_CONTACT        varchar(50)          null,
   ADDRESS              varchar(50)          null,
   SQUARE_FEET          varchar(50)          null,
   YEAR_BUILD           datetime             null,
   LOT_SIZE             varchar(50)          null,
   GARAGE               varchar(50)          null,
   NOTES                varchar(500)          null,
   constraint PK_LISTING primary key nonclustered (LISTING_ID)
)
go

/*==============================================================*/
/* Table: LISTING_IMG                                           */
/*==============================================================*/
create table LISTING_IMG (
   IMAGE_ID             int                  not null,
   LISTING_ID           int                  null,
   IMAGE_PATH           varchar(500)         null,
   IMAGE_ALT            varchar(50)          null,
   constraint PK_LISTING_IMG primary key nonclustered (IMAGE_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_1_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_1_FK on LISTING_IMG (
LISTING_ID ASC
)
go

alter table LISTING_IMG
   add constraint FK_LISTING__RELATIONS_LISTING foreign key (LISTING_ID)
      references LISTING (LISTING_ID)
go

