/*
 ----------------------------------------------------------------------------
             Génération d'une base de données pour
                        SQL Server 7.x
                       (8/3/2019 16:46:13)
 ----------------------------------------------------------------------------
     Nom de la base : GSB
     Projet : Espace de travail
     Auteur : LMC
     Date de dernière modification : 8/3/2019 16:45:53
 ----------------------------------------------------------------------------
*/



/* -----------------------------------------------------------------------------
      TABLE : ARTISTE
----------------------------------------------------------------------------- */

create table ARTISTE
  (
     IDARTISTE int  not null  ,
     NOM varchar(30)  null  
     ,
     constraint PK_ARTISTE primary key (IDARTISTE)
  ) 
go



/* -----------------------------------------------------------------------------
      TABLE : EVENEMENT
----------------------------------------------------------------------------- */

create table EVENEMENT
  (
     IDEVENEMENT int  not null  ,
     IDCAMPAGNE int  not null  ,
     DATEDEBUT datetime  null  ,
     DATEFIN datetime  null  ,
     VILLE varchar(30)  null  ,
     THEME varchar(30)  null  
     ,
     constraint PK_EVENEMENT primary key (IDEVENEMENT)
  ) 
go



/*      INDEX DE EVENEMENT      */



/* -----------------------------------------------------------------------------
      TABLE : VIP
----------------------------------------------------------------------------- */

create table VIP
  (
     IDVIP int  not null  ,
     IDCATEGORIE int  not null  ,
     NOM varchar(30)  null  ,
     ADRESSE varchar(30)  null  ,
     EMAIL varchar(30)  null  
     ,
     constraint PK_VIP primary key (IDVIP)
  ) 
go



/*      INDEX DE VIP      */



/* -----------------------------------------------------------------------------
      TABLE : CATEGORIE
----------------------------------------------------------------------------- */

create table CATEGORIE
  (
     IDCATEGORIE int  not null  ,
     IDTYPEMESSAGE int  not null  ,
     LIBELLE varchar(30)  null  
     ,
     constraint PK_CATEGORIE primary key (IDCATEGORIE)
  ) 
go



/*      INDEX DE CATEGORIE      */



/* -----------------------------------------------------------------------------
      TABLE : CAMPAGNE
----------------------------------------------------------------------------- */

create table CAMPAGNE
  (
     IDCAMPAGNE int  not null  ,
     IDEMPLOYE int  not null  ,
     IDAGENCE int  null  ,
     IDAGENCE_ORGANISATEUR_ART int  null  ,
     INTITULE varchar(30)  null  ,
     OBJECTIF varchar(30)  null  ,
     PUBLIQUE varchar(30)  null  ,
     DATEDEBUT datetime  null  ,
     DATEFIN datetime  null  
     ,
     constraint PK_CAMPAGNE primary key (IDCAMPAGNE)
  ) 
go



/*      INDEX DE CAMPAGNE      */



/* -----------------------------------------------------------------------------
      TABLE : EMPLOYE
----------------------------------------------------------------------------- */

create table EMPLOYE
  (
     IDEMPLOYE int  not null  ,
     PRENOM varchar(30)  null  ,
     NOM varchar(30)  null  ,
     MAIL varchar(30)  null  ,
     TEL char(32)  null  ,
     GENRE varchar(1)  null  ,
     GRADE char(32)  null  ,
     LOGIN varchar(30)  null  ,
     MDP varchar(70)  null  
     ,
     constraint PK_EMPLOYE primary key (IDEMPLOYE)
  ) 
go



/* -----------------------------------------------------------------------------
      TABLE : AGENCE
----------------------------------------------------------------------------- */

create table AGENCE
  (
     IDAGENCE int  not null  ,
     SPECIALITE varchar(30)  null  ,
     NOM varchar(30)  null  ,
     SITE varchar(30)  null  ,
     MAIL varchar(30)  null  ,
     TEL varchar(10)  null  ,
     ADRESSE varchar(30)  null  
     ,
     constraint PK_AGENCE primary key (IDAGENCE)
  ) 
go



/* -----------------------------------------------------------------------------
      TABLE : TYPEMESSAGE
----------------------------------------------------------------------------- */

create table TYPEMESSAGE
  (
     IDTYPEMESSAGE int  not null  ,
	 IDEVENEMENT int not null  ,
     CONTENUE varchar(128)  null  
     ,
     constraint PK_TYPEMESSAGE primary key (IDTYPEMESSAGE)
  ) 
go



/* -----------------------------------------------------------------------------
      TABLE : INVITER
----------------------------------------------------------------------------- */

create table INVITER
  (
     IDEVENEMENT int  not null  ,
     IDARTISTE int  not null  ,
     CACHET int  null  
     ,
     constraint PK_INVITER primary key (IDEVENEMENT, IDARTISTE)
  ) 
go



/*      INDEX DE INVITER      */



/* -----------------------------------------------------------------------------
      TABLE : CONVIER
----------------------------------------------------------------------------- */

create table CONVIER
  (
     IDVIP int  not null  ,
     IDEVENEMENT int  not null  ,
     DATECONVIER datetime  null  
     ,
     constraint PK_CONVIER primary key (IDVIP, IDEVENEMENT)
  ) 
go



/*      INDEX DE CONVIER      */



/* -----------------------------------------------------------------------------
      REFERENCES SUR LES TABLES
----------------------------------------------------------------------------- */



alter table EVENEMENT 
     add constraint FK_EVENEMENT_CAMPAGNE foreign key (IDCAMPAGNE) 
               references CAMPAGNE (IDCAMPAGNE)
go




alter table VIP 
     add constraint FK_VIP_CATEGORIE foreign key (IDCATEGORIE) 
               references CATEGORIE (IDCATEGORIE)
go




alter table CATEGORIE 
     add constraint FK_CATEGORIE_TYPEMESSAGE foreign key (IDTYPEMESSAGE) 
               references TYPEMESSAGE (IDTYPEMESSAGE)
go




alter table TYPEMESSAGE
	add constraint FK_TYPEMESSAGE_EVENEMENT foreign key (IDEVENEMENT)
               references EVENEMENT (IDEVENEMENT)
go




alter table CAMPAGNE 
     add constraint FK_CAMPAGNE_EMPLOYE foreign key (IDEMPLOYE) 
               references EMPLOYE (IDEMPLOYE)
go




alter table CAMPAGNE 
     add constraint FK_CAMPAGNE_AGENCE foreign key (IDAGENCE) 
               references AGENCE (IDAGENCE)
go




alter table CAMPAGNE 
     add constraint FK_CAMPAGNE_AGENCE1 foreign key (IDAGENCE_ORGANISATEUR_ART) 
               references AGENCE (IDAGENCE)
go




alter table INVITER 
     add constraint FK_INVITER_EVENEMENT foreign key (IDEVENEMENT) 
               references EVENEMENT (IDEVENEMENT)
go




alter table INVITER 
     add constraint FK_INVITER_ARTISTE foreign key (IDARTISTE) 
               references ARTISTE (IDARTISTE)
go




alter table CONVIER 
     add constraint FK_CONVIER_VIP foreign key (IDVIP) 
               references VIP (IDVIP)
go




alter table CONVIER 
     add constraint FK_CONVIER_EVENEMENT foreign key (IDEVENEMENT) 
               references EVENEMENT (IDEVENEMENT)
go




/*
 -----------------------------------------------------------------------------
               FIN DE GENERATION
 -----------------------------------------------------------------------------
*/