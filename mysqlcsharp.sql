-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 24, 2019 at 03:38 PM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mysqlcsharp`
--

-- --------------------------------------------------------

--
-- Table structure for table `assaulttable`
--

CREATE TABLE `assaulttable` (
  `Number` int(11) NOT NULL,
  `keyword` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `assaulttable`
--

INSERT INTO `assaulttable` (`Number`, `keyword`) VALUES
(5, 'Aggression'),
(7, 'incursion'),
(8, 'charge'),
(9, 'violation'),
(10, 'Rape'),
(11, 'Violence'),
(12, 'onslaught'),
(13, 'offensive'),
(14, 'sexual'),
(15, 'acquaintance'),
(16, 'intercourse '),
(17, 'molestation'),
(18, 'attempt'),
(19, 'onset'),
(20, 'raid'),
(21, 'ambush'),
(22, 'invasion'),
(23, 'invading'),
(24, 'sack'),
(25, 'bombing'),
(26, 'defense'),
(27, 'defensive'),
(28, 'guard'),
(29, 'shield'),
(30, 'protection'),
(31, 'security'),
(32, 'force'),
(33, 'violate'),
(34, 'molest'),
(35, 'sick'),
(36, 'surprise'),
(37, 'surprize'),
(38, 'bomb'),
(39, 'plaster'),
(40, 'invade'),
(41, 'shield'),
(42, 'Brutal'),
(43, 'physical'),
(44, 'abduct'),
(45, 'jump'),
(46, 'kidnap'),
(48, 'work'),
(49, 'Stab'),
(50, 'stabbing'),
(51, 'cash'),
(52, 'dead'),
(53, 'money'),
(55, 'Murderer'),
(56, 'Robbery');

-- --------------------------------------------------------

--
-- Table structure for table `bribetable`
--

CREATE TABLE `bribetable` (
  `number` int(11) NOT NULL,
  `keyword` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bribetable`
--

INSERT INTO `bribetable` (`number`, `keyword`) VALUES
(2, 'moneyy'),
(3, 'fix'),
(4, 'tamper'),
(5, 'backhander'),
(6, 'payoff'),
(7, 'slush'),
(8, 'fund'),
(9, 'allurement'),
(10, 'bait'),
(11, 'lure'),
(12, 'buy'),
(13, 'corrupt'),
(14, 'defiling'),
(15, 'defile'),
(16, 'demean'),
(17, 'degrade'),
(18, 'dishonor'),
(19, 'pervert'),
(20, 'poison'),
(21, 'motivate'),
(22, 'provoke'),
(23, 'prostitute'),
(24, 'persuade'),
(25, 'kickbacks'),
(26, 'corruptions'),
(27, 'fee'),
(28, 'blackmail'),
(29, 'reward'),
(30, 'payment'),
(31, 'influence'),
(32, 'sweet'),
(33, 'tips'),
(34, 'gifts'),
(35, 'prize'),
(36, 'present'),
(37, 'dollar'),
(38, 'Ringgit'),
(39, 'RM'),
(40, 'million'),
(41, 'diamond'),
(42, 'warrant'),
(43, 'contract'),
(44, 'terminate'),
(45, 'agreement'),
(46, 'black'),
(47, 'white'),
(48, 'compensation'),
(49, 'commission'),
(50, 'deal'),
(51, 'exchange'),
(52, 'tradeoff'),
(53, 'cash'),
(54, 'dead');

-- --------------------------------------------------------

--
-- Table structure for table `casedetail`
--

CREATE TABLE `casedetail` (
  `Examiner` varchar(50) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Description` varchar(100) NOT NULL,
  `loc` varchar(100) NOT NULL,
  `ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `casedetail`
--

INSERT INTO `casedetail` (`Examiner`, `Name`, `Description`, `loc`, `ID`) VALUES
('nur', 'kidnap', 'asd', '', 1);

-- --------------------------------------------------------

--
-- Table structure for table `cybertable`
--

CREATE TABLE `cybertable` (
  `number` int(11) NOT NULL,
  `keyword` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cybertable`
--

INSERT INTO `cybertable` (`number`, `keyword`) VALUES
(3, 'computer'),
(4, 'Cookie'),
(6, 'CyberScrub'),
(7, 'internet'),
(8, 'Delete'),
(9, 'evidence'),
(10, 'harddisk'),
(11, 'Privacy'),
(12, 'BitTorrent'),
(13, 'Share'),
(14, 'Hide'),
(15, 'Transmission'),
(16, 'WireShark'),
(17, 'Hidden'),
(18, 'Seek'),
(19, 'Unhide'),
(20, 'Hideme'),
(21, 'Invisible'),
(22, 'Spyder'),
(23, 'Spam'),
(24, 'Fraud'),
(25, 'bank'),
(26, 'money'),
(27, 'password'),
(28, 'passwd'),
(29, 'pwrd'),
(30, 'username'),
(31, 'fih'),
(32, 'date');

-- --------------------------------------------------------

--
-- Table structure for table `drugtable`
--

CREATE TABLE `drugtable` (
  `Number` int(11) NOT NULL,
  `keyword` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `drugtable`
--

INSERT INTO `drugtable` (`Number`, `keyword`) VALUES
(153, 'cap'),
(154, 'capsule'),
(155, 'pill'),
(156, 'tablet'),
(157, 'tonic'),
(158, 'abuse'),
(159, 'clean'),
(160, 'bust'),
(161, 'cold'),
(162, 'crack'),
(163, 'crackhouse'),
(164, 'habit '),
(165, 'High'),
(166, 'hit'),
(167, 'Hookah'),
(168, 'OD'),
(169, 'overdose'),
(170, 'rehabilitate'),
(171, 'rehab'),
(172, 'rush'),
(173, 'withdrawal'),
(174, 'unpleasant'),
(175, 'injection'),
(176, 'shot'),
(177, 'needle'),
(178, 'candle'),
(179, 'powder'),
(180, 'weed'),
(181, 'ice'),
(182, 'cocaine'),
(183, 'coke'),
(184, 'aspirin'),
(185, 'cough'),
(186, 'alcohol'),
(187, 'happy'),
(188, 'money'),
(189, 'rush'),
(190, 'ambush'),
(191, 'police'),
(192, 'Detective'),
(193, 'harm'),
(194, 'toxic'),
(195, 'Marijuana'),
(196, 'Cannabis'),
(197, 'MDMA'),
(198, 'Ecstasy'),
(199, 'GHB'),
(200, 'Ketamine'),
(201, 'Heroin'),
(202, 'stimulant'),
(203, 'depressant'),
(204, 'caffeine'),
(205, 'speed'),
(206, 'concentration'),
(207, 'ability'),
(208, 'brain'),
(209, 'Heaven'),
(210, 'LSD'),
(211, 'paracetalmol');

-- --------------------------------------------------------

--
-- Table structure for table `evidence`
--

CREATE TABLE `evidence` (
  `Location` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `fraudtable`
--

CREATE TABLE `fraudtable` (
  `Number` int(11) NOT NULL,
  `Keyword` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `fraudtable`
--

INSERT INTO `fraudtable` (`Number`, `Keyword`) VALUES
(1, 'lie'),
(2, 'blackmail'),
(3, 'scam'),
(4, 'artifice'),
(5, 'deceit'),
(6, 'hoax'),
(7, 'extortation'),
(8, 'Cheat'),
(9, 'swindle'),
(10, 'imposture'),
(11, 'skunk'),
(12, 'phishing'),
(13, 'fraudulence'),
(14, 'shady'),
(15, 'pretender'),
(16, 'duplicate'),
(17, 'fraudster'),
(18, 'deception'),
(19, 'damage'),
(20, 'money'),
(21, 'trick'),
(22, 'forgery'),
(23, 'breach'),
(24, 'mislead'),
(25, 'upset');

-- --------------------------------------------------------

--
-- Table structure for table `harasstable`
--

CREATE TABLE `harasstable` (
  `Number` int(11) NOT NULL,
  `Keyword` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `harasstable`
--

INSERT INTO `harasstable` (`Number`, `Keyword`) VALUES
(1, 'threat'),
(2, 'torture'),
(3, 'money'),
(4, 'kill'),
(5, 'dead'),
(6, 'family'),
(7, 'kids'),
(8, 'child'),
(9, 'careful'),
(10, 'work'),
(11, 'workplace'),
(12, 'house'),
(13, 'hostile'),
(14, 'molest'),
(15, 'sexual'),
(16, 'bother'),
(17, 'anger'),
(18, 'pain'),
(19, 'debt'),
(20, 'embarassed'),
(21, 'offensive');

-- --------------------------------------------------------

--
-- Table structure for table `hatetable`
--

CREATE TABLE `hatetable` (
  `Number` int(11) NOT NULL,
  `Keyword` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `hatetable`
--

INSERT INTO `hatetable` (`Number`, `Keyword`) VALUES
(1, 'terrorism'),
(2, 'gun'),
(3, 'bomb'),
(4, 'nuclear'),
(5, 'race'),
(6, 'religion'),
(7, 'transgender'),
(8, 'identity'),
(9, 'sexual'),
(10, 'graffiti'),
(11, 'arson'),
(12, 'noise'),
(13, 'muslim'),
(14, 'family'),
(15, 'debt'),
(16, 'prejudice'),
(17, 'violence'),
(18, 'bias'),
(19, 'vandalism'),
(20, 'white'),
(21, 'black'),
(22, 'people'),
(23, 'islamophobia'),
(24, 'injury'),
(25, 'nazism');

-- --------------------------------------------------------

--
-- Table structure for table `murdertable`
--

CREATE TABLE `murdertable` (
  `number` int(11) NOT NULL,
  `keyword` varchar(50) NOT NULL,
  `regex` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `murdertable`
--

INSERT INTO `murdertable` (`number`, `keyword`, `regex`) VALUES
(2, 'Blood', 'True'),
(3, ' brutal', 'False'),
(4, ' injury', 'False'),
(5, ' injuries', 'False'),
(6, ' burn', 'False'),
(7, ' KILL', 'False'),
(8, ' K!Ll', 'True'),
(11, 'target', 'False'),
(12, 'gnr', 'False'),
(13, 'kill', 'False'),
(14, 'Blade', ''),
(15, 'murderer', ''),
(16, 'knife', ''),
(17, 'bomb', ''),
(18, 'dagger', ''),
(19, 'gun', ''),
(20, 'pistol', ''),
(21, 'shooter', ''),
(22, 'Sniper', ''),
(23, 'mafia', ''),
(24, 'abused', ''),
(25, 'hooligan', ''),
(26, 'vandal', ''),
(27, 'snooper', ''),
(28, 'weirdo', ''),
(29, 'fire', ''),
(30, 'arson', ''),
(31, 'alcohol', '');

-- --------------------------------------------------------

--
-- Table structure for table `mysqlcsharp`
--

CREATE TABLE `mysqlcsharp` (
  `id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `email` varchar(50) NOT NULL,
  `phone_num` int(11) NOT NULL,
  `fullname` varchar(200) NOT NULL,
  `address` varchar(200) NOT NULL,
  `Marital_status` varchar(50) NOT NULL,
  `Gender` varchar(50) NOT NULL,
  `ic` int(11) NOT NULL,
  `Date` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mysqlcsharp`
--

INSERT INTO `mysqlcsharp` (`id`, `username`, `password`, `email`, `phone_num`, `fullname`, `address`, `Marital_status`, `Gender`, `ic`, `Date`) VALUES
(13, 'admins', '751202525920127203199220354316823689224', '', 0, '', '', 'Other', 'Female', 0, '0000-00-00'),
(14, 'syafiqah', '2161632933913413719233023116176150', 'syafiqah123@gmail.com', 182577550, 'syafiqah hanisah', 'Parit Raja, Johor', 'Single', 'Female', 0, '1997-03-15'),
(15, 'anis', '13515316420710617277137144189226561241176', 'anis@gmail.com', 123456789, 'anis', 'taman u', '', '', 0, ''),
(16, 'syafiqah123', '13570992521813125475223762342331169987', 'han@gmail.com', 12345678, 'hanisah', 'uthm', '', '', 0, ''),
(17, 'JaneD', '652016250414368713183444524158', 'janeD@gmail.com', 2147483647, 'Jane Doe', 'Taman Universit, Parit Raja, Johor.', '', '', 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `pedotable`
--

CREATE TABLE `pedotable` (
  `number` int(11) NOT NULL,
  `keyword` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pedotable`
--

INSERT INTO `pedotable` (`number`, `keyword`) VALUES
(3, 'child'),
(4, 'kid'),
(5, 'boy'),
(6, 'girl'),
(7, 'little'),
(8, 'icecream'),
(9, 'cream'),
(10, 'semen'),
(11, 'Lover'),
(12, 'Naked'),
(13, 'underage'),
(14, '12yrs'),
(15, 'preteen'),
(16, 'teensex'),
(17, 'kiss'),
(18, 'school'),
(19, 'Prostitution'),
(20, 'biological'),
(21, 'Adopt'),
(22, 'puberty'),
(23, 'incest'),
(24, 'pervert'),
(25, 'deviant'),
(26, 'stalker'),
(27, 'predator'),
(28, 'fantasy');

-- --------------------------------------------------------

--
-- Table structure for table `porntable`
--

CREATE TABLE `porntable` (
  `number` int(11) NOT NULL,
  `keyword` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `porntable`
--

INSERT INTO `porntable` (`number`, `keyword`) VALUES
(1, 'children'),
(5, 'Straight'),
(6, 'boyfriend'),
(7, 'girlfriend'),
(8, 'drunk'),
(9, 'party_'),
(10, 'pedophil'),
(11, '2crazygurls1'),
(13, 'abigail'),
(14, 'hotel'),
(15, 'Abyj'),
(16, 'ADINA_JEWE'),
(17, 'ADOLECENTE'),
(18, 'ASHLEY'),
(19, 'angela'),
(20, 'angelcollection'),
(21, 'angelfuns'),
(22, 'ASIAN'),
(23, 'ASIAN-PTHC'),
(24, 'baby1001'),
(25, 'babyfuck'),
(26, 'babygrl'),
(27, 'babyh'),
(28, 'boy'),
(29, 'boylove'),
(30, 'boylover'),
(31, 'boyparty'),
(32, 'children'),
(33, 'CH*LD'),
(34, 'CH*LD_P*RN'),
(35, 'C.H.!.L.D'),
(36, 'C.H.I.L.L...A.C.T.I.O.N'),
(37, 'C.H.I.L.L.P.O.R.N.O'),
(38, 'C/P.orno'),
(39, 'candygirls'),
(40, 'Casandra'),
(41, 'CASEY'),
(42, 'cbaby'),
(43, 'CH!LD_MOLESTATION'),
(44, 'child por'),
(45, 'child animal'),
(46, 'child extreme'),
(48, 'Cuntpreteen'),
(49, 'DADDAUGHTER'),
(51, 'DAddy');

-- --------------------------------------------------------

--
-- Table structure for table `rapetable`
--

CREATE TABLE `rapetable` (
  `number` int(11) NOT NULL,
  `keyword` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `rapetable`
--

INSERT INTO `rapetable` (`number`, `keyword`) VALUES
(1, 'Accessory'),
(2, 'Abuss'),
(3, 'Alcohol'),
(4, 'Allegation'),
(5, 'Arrest'),
(6, 'Assault'),
(7, 'Attack'),
(8, 'Behavior'),
(9, 'Blackmail'),
(10, 'Bloodstain'),
(11, 'Brawl'),
(12, 'Breach'),
(13, 'Breaking '),
(14, 'Brutal'),
(15, 'Burglary'),
(16, 'Burglar'),
(17, 'Brutality'),
(18, 'Chase'),
(19, 'Chasing'),
(20, 'Damage'),
(21, 'Dark '),
(22, 'Handcuffs'),
(23, 'Harassment'),
(24, 'Hire'),
(25, 'Hostage'),
(26, 'Illegal'),
(27, 'Identification'),
(28, 'Sexual'),
(29, 'Sex'),
(30, 'Fun'),
(31, 'Injury'),
(32, 'homicide '),
(33, 'partner '),
(34, 'violence'),
(35, 'influence'),
(36, 'males'),
(37, 'male'),
(38, 'preteen'),
(39, 'schoolgirl'),
(40, 'russiangirlz'),
(41, 'TEENGIRL'),
(42, 'Teenie'),
(43, 'Teensex'),
(44, 'YOUNGFRIENDS'),
(45, 'Webcam'),
(46, 'viola'),
(47, 'Urination'),
(48, 'yogirl'),
(49, 'Youngporn'),
(50, 'gangbang'),
(51, 'saw');

-- --------------------------------------------------------

--
-- Table structure for table `traffictable`
--

CREATE TABLE `traffictable` (
  `Number` int(11) NOT NULL,
  `Keyword` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `traffictable`
--

INSERT INTO `traffictable` (`Number`, `Keyword`) VALUES
(1, 'human'),
(2, 'prostitution'),
(3, 'girl'),
(4, 'kids'),
(6, 'child'),
(7, 'labor'),
(8, 'organ'),
(9, 'sex'),
(10, 'activity'),
(11, 'foreign'),
(12, 'virgin'),
(13, 'sell'),
(14, 'kidnap'),
(15, 'kidney'),
(16, 'eyes'),
(17, 'forced'),
(18, 'marriage'),
(19, 'abuse'),
(20, 'slavery'),
(21, 'trade'),
(22, 'abduction'),
(23, 'smuggling'),
(24, 'trafficker'),
(25, 'entertainment'),
(26, 'victim'),
(27, 'bloodshed'),
(28, 'illegal'),
(29, 'immigrant');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `assaulttable`
--
ALTER TABLE `assaulttable`
  ADD UNIQUE KEY `assaultble` (`Number`);

--
-- Indexes for table `bribetable`
--
ALTER TABLE `bribetable`
  ADD UNIQUE KEY `bribe` (`number`);

--
-- Indexes for table `casedetail`
--
ALTER TABLE `casedetail`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `cybertable`
--
ALTER TABLE `cybertable`
  ADD UNIQUE KEY `cybertble` (`number`);

--
-- Indexes for table `drugtable`
--
ALTER TABLE `drugtable`
  ADD UNIQUE KEY `drugtbl` (`Number`);

--
-- Indexes for table `fraudtable`
--
ALTER TABLE `fraudtable`
  ADD UNIQUE KEY `fraud` (`Number`);

--
-- Indexes for table `harasstable`
--
ALTER TABLE `harasstable`
  ADD UNIQUE KEY `harass` (`Number`);

--
-- Indexes for table `hatetable`
--
ALTER TABLE `hatetable`
  ADD UNIQUE KEY `hate` (`Number`);

--
-- Indexes for table `murdertable`
--
ALTER TABLE `murdertable`
  ADD UNIQUE KEY `murdertable` (`number`);

--
-- Indexes for table `mysqlcsharp`
--
ALTER TABLE `mysqlcsharp`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pedotable`
--
ALTER TABLE `pedotable`
  ADD UNIQUE KEY `pedophile` (`number`);

--
-- Indexes for table `porntable`
--
ALTER TABLE `porntable`
  ADD UNIQUE KEY `porntable` (`number`);

--
-- Indexes for table `rapetable`
--
ALTER TABLE `rapetable`
  ADD UNIQUE KEY `rapetble` (`number`);

--
-- Indexes for table `traffictable`
--
ALTER TABLE `traffictable`
  ADD UNIQUE KEY `traffic` (`Number`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `assaulttable`
--
ALTER TABLE `assaulttable`
  MODIFY `Number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- AUTO_INCREMENT for table `bribetable`
--
ALTER TABLE `bribetable`
  MODIFY `number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;

--
-- AUTO_INCREMENT for table `cybertable`
--
ALTER TABLE `cybertable`
  MODIFY `number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `drugtable`
--
ALTER TABLE `drugtable`
  MODIFY `Number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=212;

--
-- AUTO_INCREMENT for table `fraudtable`
--
ALTER TABLE `fraudtable`
  MODIFY `Number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `harasstable`
--
ALTER TABLE `harasstable`
  MODIFY `Number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `hatetable`
--
ALTER TABLE `hatetable`
  MODIFY `Number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `murdertable`
--
ALTER TABLE `murdertable`
  MODIFY `number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT for table `mysqlcsharp`
--
ALTER TABLE `mysqlcsharp`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `pedotable`
--
ALTER TABLE `pedotable`
  MODIFY `number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `porntable`
--
ALTER TABLE `porntable`
  MODIFY `number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

--
-- AUTO_INCREMENT for table `rapetable`
--
ALTER TABLE `rapetable`
  MODIFY `number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

--
-- AUTO_INCREMENT for table `traffictable`
--
ALTER TABLE `traffictable`
  MODIFY `Number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
