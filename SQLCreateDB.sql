CREATE TABLE tridy_SCP_Objektu (
  
  trida_id Integer IDENTITY PRIMARY KEY, 
  trida VARCHAR(30) NOT NULL,
)
ON "default"
GO

CREATE TABLE zaznam_SCP_Objektu (
  
  zaznam_id Integer IDENTITY PRIMARY KEY, 
  cisloZaznamu Integer NOT NULL,
  textZaznamu VARCHAR(1000) NOT NULL,
  trida_id Integer CONSTRAINT FK_TRIDYzaznamSCPO FOREIGN KEY (trida_id) REFERENCES tridy_SCP_Objektu (trida_id),
  proverka Integer NOT NULL,
  dodatek_id Integer,
)
ON "default"
GO

CREATE TABLE SCP_Objekt (
  scp_id Integer PRIMARY KEY NOT NULL,
  prezdivka VARCHAR(30) NOT NULL,
  trida_id Integer CONSTRAINT FK_TRIDY FOREIGN KEY (trida_id) REFERENCES tridy_SCP_Objektu (trida_id),
  zaznam_id Integer CONSTRAINT FK_ZAZNAM FOREIGN KEY (zaznam_id) REFERENCES zaznam_SCP_Objektu (zaznam_id),
  proverka Integer NOT NULL,
  dodatek_id integer
)
ON "default"
GO

CREATE TABLE ucty
(
  login VARCHAR(30) NOT NULL,
  heslo VARCHAR(30) NOT NULL,
  ID_pracovnika Integer IDENTITY PRIMARY KEY NOT NULL,
  proverka Integer NOT NULL,
  pozice VARCHAR(30) NOT NULL,
  jmeno VARCHAR(30) NOT NULL,
  tym VARCHAR(30),
  nadrizenyPracovnik_id INTEGER,
  nazevJednotky VARCHAR(30),
  scp_id Integer CONSTRAINT FK_SCP_OBJEKT FOREIGN KEY (scp_id) REFERENCES SCP_Objekt (scp_id),
  cisloOblasti Integer NOT NULL
)
ON "default"
GO

CREATE TABLE vyzkumnik (
	vyzkumnik_ID Integer IDENTITY PRIMARY KEY NOT NULL,
	vedec_id Integer CONSTRAINT FK_Ucty FOREIGN KEY (vedec_id) REFERENCES ucty (ID_pracovnika)
)
ON "default"
GO

CREATE TABLE Vrchni_vyzkumnik (
	Vrchni_vyzkumnik_ID Integer IDENTITY PRIMARY KEY NOT NULL,
	vedec_id Integer CONSTRAINT FK_UctyVV FOREIGN KEY (vedec_id) REFERENCES ucty (ID_pracovnika) NOT NULL,
)
ON "default"
GO

CREATE TABLE jednotka_NTF (
  
  nazev VARCHAR(30) NOT NULL,
  pocet_Clenu Integer NOT NULL,
  clen_id Integer CONSTRAINT FK_CLENNTF FOREIGN KEY (clen_id) REFERENCES ucty (ID_pracovnika),
  vybaveni VARCHAR(50) NOT NULL,
  popis VARCHAR(60) NOT NULL,
  ID_jednotky Integer IDENTITY PRIMARY KEY,
  dostupnost BIT NOT NULL,
  typMise VARCHAR(30)
)
ON "default"
GO

INSERT INTO  tridy_SCP_Objektu( trida)
VALUES ('Safe'), ('Euclid'), ('Keter'), ('Thaumiel')  

INSERT INTO zaznam_SCP_Objektu (cisloZaznamu, textZaznamu, trida_id, proverka, dodatek_id)
VALUES
	(1, 'Moved to Site-19 1993. Origin is as of yet unknown.
	It is constructed from concrete and rebar with traces of Krylon brand spray paint.
	SCP-173 is animate and extremely hostile. The object cannot move while within a direct line of sight.
	Line of sight must not be broken at any time with SCP-173.', 3, 2, NULL),
	
	(1, 'SCP-079 is an Exidy Sorcerer microcomputer built in 1978. In 1981, its owner, █████ ██████ (deceased),
	a college sophomore attending ███, took it upon himself to attempt to code an AI. According to his notes,
	his plan was for the code to continuously evolve and improve itself as time went on. His project was completed a few months later,
	and after some tests and tweaks, █████ lost interest and moved on to a different brand of microcomputer. He left SCP-079 in his cluttered garage,
	still plugged in, and forgot about it for the next five years.
	It is not known when SCP-079 gained sentience.',3, 2, 0791),

	(1, ' SCP-999 appears to be a large, amorphous, gelatinous mass of translucent orange slime, weighing about 54 kg (120 lbs) with a consistency similar to that of peanut butter. 
		Subject’s size and shape is easily malleable and can change shape at will,
		though when at rest, SCP-999 becomes a rounded, oblate dome roughly 2 meters wide and 1 meter in height.', 1, 1, 9991)

INSERT INTO SCP_Objekt (scp_id, prezdivka, trida_id, zaznam_id, proverka, dodatek_id)
VALUES 
	(173, 'Sculpture', 2, 1, 3, NULL),
	(079, 'Old AI', 2 , 2, 3, 0791),
	(999, 'Thickle monster', 1, 3, 1, 9991),
	(860, 'Blue Key', 1, NULL, 2, NULL),
	(993, 'Bobble the Clown', 1, NULL, 2, NULL),
	(871, 'Self-Replacing Cake' , 3, NULL, 2, NULL),
	(765, 'Duck Pond', 1 , NULL, 1, NULL),
	(709, 'Eye of the Forest', 1, NULL, 3, NULL),
	(614, 'IP Address 57.32.███.███', 2, NULL, 4, NULL)

--	select * from zaznam_SCP_Objektu
--drop table ucty
--drop table vyzkumnik
--drop table Vrchni_vyzkumnik
--drop table jednotka_NTF
--drop table tridy_SCP_Objektu
--drop table zaznam_SCP_Objektu
--drop table SCP_Objekt

INSERT INTO ucty(  login, heslo, proverka, pozice, jmeno, tym, nadrizenyPracovnik_id, nazevJednotky, scp_id, cisloOblasti)
VALUES
('LOL0642', '1234', 3, 'Vyzkumnik', 'Lotrando Saliery', 'SCP-173-1', 7, NULL, 173, 19),
('BOR6014', 'heslo', 2, 'Vyzkumnik', 'Borgoloměj Sandre', NULL, NULL, NULL, NULL, 18),
('BIR6058', 'PaSsWoRd', 3, 'Vyzkumnik', 'Birglác Baltazar Svěcenský', NULL, NULL, NULL, NULL, 18),
('BIL3014', 'Left4Dead', 2, 'Vyzkumnik', 'William Bill Overbeck', NULL, NULL, NULL, NULL, 18),
('GNO3014', 'Shmebulock', 1, 'Vyzkumnik', 'Gnome Chompski', 'SCP-173-1', 7, NULL, 173, 19),
('RIC0101', 'RollingIsMaDuty', 4,  'Vrchni Vyzkumnik', 'Rick Lastly', NULL, NULL, NULL, 173, 18),
('DRB0154', 'SCP4EVER', 6, 'Vrchni Vyzkumnik', 'Thomas Bright', 'SCP-173-1', NULL, NULL, NULL, 19),
('KRA0123', 'Krkonoše', 4, 'Vrchni Vyzkumnik', 'Krakonoš z Krkonoš', NULL, NULL, NULL, NULL, 18)

INSERT INTO vyzkumnik (vedec_id)
VALUES (1), (2), (3), (4), (5) 

INSERT INTO Vrchni_vyzkumnik
VALUES (6), (7), (8)

-- ISNULL(scp_id, 'N/A') AS 




--UPDATE zaznam_SCP_Objektu
--SET cisloZaznamu = 079
--WHERE zaznam_id = 2

--DELETE zaznam_SCP_Objektu
--WHERE zaznam_id = 4

SELECT login, heslo, ID_pracovnika , proverka, pozice, jmeno, ISNULL(tym, 'N/A') AS tym, ISNULL(nadrizenyPracovnik_id, -10) AS nadrizenyPracovnik_id, ISNULL(nazevJednotky, 'N/A') AS nazevJednotky, ISNULL(scp_id, -10) AS scp_id, cisloOblasti  FROM ucty WHERE ID_pracovnika = 6

SELECT scp_id, prezdivka, ISNULL(zaznam_id, -10) AS zaznam_id, proverka, ISNULL(dodatek_id, -10) AS dodatek_id, (SELECT trida FROM tridy_SCP_Objektu WHERE SCP_Objekt.trida_id = tridy_SCP_Objektu.trida_id)  
FROM 
	SCP_Objekt 
	JOIN tridy_SCP_Objektu t ON SCP_Objekt.trida_id = t.trida_id

SELECT scp_id, prezdivka, ISNULL(zaznam_id, -10) AS zaznam_id, proverka, ISNULL(dodatek_id, -10) AS dodatek_id, (SELECT trida FROM tridy_SCP_Objektu WHERE SCP_Objekt.trida_id = tridy_SCP_Objektu.trida_id)
               FROM SCP_Objekt

SELECT * FROM ucty

SELECT * FROM zaznam_SCP_Objektu

SELECT * FROM tridy_SCP_Objektu

CREATE TABLE Nalada (
id SMALLINT,
pojmenovani VARCHAR(30),
dulezitost INTEGER
)

ALTER TABLE Nalada 
DROP COLUMN dulezitost