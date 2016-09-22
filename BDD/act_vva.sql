-- phpMyAdmin SQL Dump
-- version 3.4.9
-- http://www.phpmyadmin.net
--
-- Client: 127.0.0.1
-- Généré le : Jeu 22 Septembre 2016 à 10:23
-- Version du serveur: 5.5.20
-- Version de PHP: 5.3.9

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données: `act_vva`
--

-- --------------------------------------------------------

--
-- Structure de la table `activite`
--

CREATE TABLE IF NOT EXISTS `activite` (
  `CODEANIM` char(8) NOT NULL,
  `DATEACT` date NOT NULL,
  `NOENCADRANT` int(3) DEFAULT NULL,
  `CODEETATACT` char(2) NOT NULL,
  `HRRDVACT` time DEFAULT NULL,
  `PRIXACT` decimal(7,2) DEFAULT NULL,
  `HRDEBUTACT` time DEFAULT NULL,
  `HRFINACT` time DEFAULT NULL,
  `DATEANNULATIONACT` date DEFAULT NULL,
  `OBJECTIFACT` char(255) DEFAULT NULL,
  PRIMARY KEY (`CODEANIM`,`DATEACT`),
  KEY `I_FK_ACTIVITE_ANIMATION` (`CODEANIM`),
  KEY `I_FK_ACTIVITE_ENCADRANT` (`NOENCADRANT`),
  KEY `I_FK_ACTIVITE_ETAT_ACT` (`CODEETATACT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `animation`
--

CREATE TABLE IF NOT EXISTS `animation` (
  `CODEANIM` char(8) NOT NULL,
  `CODETYPEANIM` char(5) NOT NULL,
  `NOMANIM` char(40) DEFAULT NULL,
  `DATECREATIONANIM` date DEFAULT NULL,
  `DATEVALIDITEANIM` date DEFAULT NULL,
  `DUREEANIM` double(5,0) DEFAULT NULL,
  `LIMITEAGE` int(2) DEFAULT NULL,
  `TARIFANIM` decimal(7,2) DEFAULT NULL,
  `NBREPLACEANIM` int(2) DEFAULT NULL,
  `DESCRIPTANIM` char(255) DEFAULT NULL,
  `COMMENTANIM` char(255) DEFAULT NULL,
  `DIFFICULTEANIM` char(40) DEFAULT NULL,
  PRIMARY KEY (`CODEANIM`),
  KEY `I_FK_ANIMATION_TYPE_ANIM` (`CODETYPEANIM`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `encadrant`
--

CREATE TABLE IF NOT EXISTS `encadrant` (
  `NOENCADRANT` int(3) NOT NULL,
  `USER` char(8) NOT NULL,
  `NOMENCADRANT` char(40) DEFAULT NULL,
  `PRENOMENCADRANT` char(30) DEFAULT NULL,
  `DATENAISENCADRANT` date DEFAULT NULL,
  `ADRMAILENCADRANT` char(50) DEFAULT NULL,
  `ETATSERVICE` char(200) DEFAULT NULL,
  PRIMARY KEY (`NOENCADRANT`),
  UNIQUE KEY `I_FK_ENCADRANT_PROFIL` (`USER`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `etat_act`
--

CREATE TABLE IF NOT EXISTS `etat_act` (
  `CODEETATACT` char(2) NOT NULL,
  `NOMETATACT` char(25) DEFAULT NULL,
  PRIMARY KEY (`CODEETATACT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `inscription`
--

CREATE TABLE IF NOT EXISTS `inscription` (
  `NOLOISANT` int(6) NOT NULL,
  `NOINSCRIP` bigint(4) NOT NULL,
  `CODEANIM` char(8) NOT NULL,
  `DATEACT` date NOT NULL,
  `DATEINSCRIP` date DEFAULT NULL,
  `REMARQUEINSCRIP` char(255) DEFAULT NULL,
  `DATE_ANNULATION` date DEFAULT NULL,
  PRIMARY KEY (`NOLOISANT`,`NOINSCRIP`),
  KEY `I_FK_INSCRIPTION_LOISANT` (`NOLOISANT`),
  KEY `I_FK_INSCRIPTION_ACTIVITE` (`CODEANIM`,`DATEACT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `loisant`
--

CREATE TABLE IF NOT EXISTS `loisant` (
  `NOLOISANT` int(6) NOT NULL,
  `USER` char(8) NOT NULL,
  `NOMLOISANT` char(40) DEFAULT NULL,
  `PRENOMLOISANT` char(30) DEFAULT NULL,
  `DATEDEBSEJOUR` date DEFAULT NULL,
  `DATEFINSEJOUR` date DEFAULT NULL,
  `DATENAISLOISANT` date DEFAULT NULL,
  PRIMARY KEY (`NOLOISANT`),
  UNIQUE KEY `I_FK_LOISANT_PROFIL` (`USER`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `planning`
--

CREATE TABLE IF NOT EXISTS `planning` (
  `NOENCADRANT` int(3) NOT NULL,
  `CODEANIM` char(8) NOT NULL,
  `DATEACT` date NOT NULL,
  PRIMARY KEY (`NOENCADRANT`,`CODEANIM`,`DATEACT`),
  KEY `I_FK_PLANNING_ENCADRANT` (`NOENCADRANT`),
  KEY `I_FK_PLANNING_ACTIVITE` (`CODEANIM`,`DATEACT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `profil`
--

CREATE TABLE IF NOT EXISTS `profil` (
  `USER` char(8) NOT NULL,
  `MDP` char(10) DEFAULT NULL,
  `NOMPROFIL` char(40) DEFAULT NULL,
  `PRENOMPROFIL` char(30) DEFAULT NULL,
  `DATEINSPRO` date DEFAULT NULL,
  `DATEVALIDITE` date DEFAULT NULL,
  `TYPEPROFIL` char(2) DEFAULT NULL,
  PRIMARY KEY (`USER`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `type_anim`
--

CREATE TABLE IF NOT EXISTS `type_anim` (
  `CODETYPEANIM` char(5) NOT NULL,
  `NOMTYPEANIM` char(50) DEFAULT NULL,
  PRIMARY KEY (`CODETYPEANIM`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `activite`
--
ALTER TABLE `activite`
  ADD CONSTRAINT `activite_ibfk_3` FOREIGN KEY (`CODEETATACT`) REFERENCES `etat_act` (`CODEETATACT`),
  ADD CONSTRAINT `activite_ibfk_1` FOREIGN KEY (`CODEANIM`) REFERENCES `animation` (`CODEANIM`),
  ADD CONSTRAINT `activite_ibfk_2` FOREIGN KEY (`NOENCADRANT`) REFERENCES `encadrant` (`NOENCADRANT`);

--
-- Contraintes pour la table `animation`
--
ALTER TABLE `animation`
  ADD CONSTRAINT `animation_ibfk_1` FOREIGN KEY (`CODETYPEANIM`) REFERENCES `type_anim` (`CODETYPEANIM`);

--
-- Contraintes pour la table `encadrant`
--
ALTER TABLE `encadrant`
  ADD CONSTRAINT `encadrant_ibfk_1` FOREIGN KEY (`USER`) REFERENCES `profil` (`USER`);

--
-- Contraintes pour la table `inscription`
--
ALTER TABLE `inscription`
  ADD CONSTRAINT `inscription_ibfk_2` FOREIGN KEY (`CODEANIM`, `DATEACT`) REFERENCES `activite` (`CODEANIM`, `DATEACT`),
  ADD CONSTRAINT `inscription_ibfk_1` FOREIGN KEY (`NOLOISANT`) REFERENCES `loisant` (`NOLOISANT`);

--
-- Contraintes pour la table `loisant`
--
ALTER TABLE `loisant`
  ADD CONSTRAINT `loisant_ibfk_1` FOREIGN KEY (`USER`) REFERENCES `profil` (`USER`);

--
-- Contraintes pour la table `planning`
--
ALTER TABLE `planning`
  ADD CONSTRAINT `planning_ibfk_2` FOREIGN KEY (`CODEANIM`, `DATEACT`) REFERENCES `activite` (`CODEANIM`, `DATEACT`),
  ADD CONSTRAINT `planning_ibfk_1` FOREIGN KEY (`NOENCADRANT`) REFERENCES `encadrant` (`NOENCADRANT`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
