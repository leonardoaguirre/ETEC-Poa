-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 30-Nov-2016 às 20:24
-- Versão do servidor: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `webclothing`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `contato`
--

CREATE TABLE `contato` (
  `con_cod` int(6) NOT NULL,
  `con_nome` varchar(45) NOT NULL,
  `con_email` varchar(45) NOT NULL,
  `con_telefone` int(11) NOT NULL,
  `con_mensagem` varchar(400) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `contato`
--

INSERT INTO `contato` (`con_cod`, `con_nome`, `con_email`, `con_telefone`, `con_mensagem`) VALUES
(1, 'leonardo', 'leonardo.aguirre@etec.sp.gov.br', 1112345678, 'aaaaaaaaaaaaasssssddd');

-- --------------------------------------------------------

--
-- Estrutura da tabela `entrega`
--

CREATE TABLE `entrega` (
  `numero_pedido` int(11) NOT NULL,
  `cliente` varchar(150) NOT NULL,
  `endereco` text NOT NULL,
  `nome_destinatario` varchar(60) NOT NULL,
  `numero_cartao` int(16) NOT NULL,
  `nome_cartao` varchar(60) NOT NULL,
  `vencimento_cartao` date NOT NULL,
  `numero_seguranca_cartao` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `pedido`
--

CREATE TABLE `pedido` (
  `codigo` int(11) NOT NULL,
  `cliente` int(11) NOT NULL,
  `itens` text NOT NULL,
  `codigo_itens` int(11) NOT NULL,
  `valor` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--

CREATE TABLE `produtos` (
  `id` int(11) NOT NULL,
  `nome` varchar(255) NOT NULL,
  `descricao` text NOT NULL,
  `preco` decimal(10,0) NOT NULL,
  `imagem` int(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `produtos`
--

INSERT INTO `produtos` (`id`, `nome`, `descricao`, `preco`, `imagem`) VALUES
(1, 'calça jeans preta', 'melhor jeans do mercado', 50, 1),
(2, 'blusa preta', 'tecido leve', 15, 2),
(3, 'blusa branca', 'pano ultra fino', 20, 3),
(4, 'shorts jeans', 'super leve e resistente', 30, 4),
(5, 'saia azul ', 'saia leve', 25, 5),
(6, 'blusa branca com estampa', 'super leve, e confortavel', 15, 6),
(7, 'camiseta branca basica', 'estilo basico liso', 15, 7),
(8, 'blusinha amarela', 'blusa estilosa e simples', 25, 8),
(9, 'blusinha cinza', 'super linda e elegante', 30, 9),
(10, 'blusinha branca fitness', 'para quem faz exercicios fisicos', 15, 10),
(11, 'saia preta', 'saia lisa e moderna', 20, 11),
(12, 'saia azul', 'saia lisa curta', 25, 12),
(13, 'saia preta curta', 'saia lisa curta', 25, 13),
(14, 'blusa azul', 'leve com tecido fino', 15, 14),
(15, 'camiseta azul', 'leve e fina', 15, 15),
(16, 'camiseta azul escura', 'comum lisa', 10, 16),
(17, 'blusa branca e vermelha', 'tomara que caia com bolinhas brancas', 25, 17),
(18, 'camiseta branca', 'com estampa, e fina', 20, 18),
(19, 'vestido amarelo', 'vestido curto com bolinhas', 40, 19),
(20, 'camiseta branca', 'camiseta lisa com estampa', 15, 20),
(21, 'saia azul com flores', 'saia curta com flores brancas e vermelhas', 30, 21),
(22, 'blusa branca', 'blusa com estampa', 15, 22),
(23, 'camiseta cinza', 'camiseta cinza comum', 10, 23),
(24, 'camiseta branca', 'camiseta branca com estampa', 15, 24),
(25, 'camiseta fina transparente', 'camiseta transparente com estampa', 25, 25),
(26, 'camiseta verde', 'camiseta lisa comum', 15, 26),
(27, 'blusa laranja', 'blusa curta e leve', 15, 27),
(28, 'blusa branca', 'blusa com estampa', 15, 28),
(29, 'blusa rosa', 'blusa com estampa fina e leve', 15, 29),
(30, 'blusa verde', 'blusa simples', 10, 30),
(31, 'blusa branca', 'blusa branca com estampa fina', 15, 31),
(32, 'blusa rosa', 'blusa  leve com estampa', 15, 32),
(33, 'blusa branca', 'blusa leve com estampa', 15, 33),
(34, 'blusa branca', 'blusa comum com estampa', 15, 34),
(35, 'blusa regata branca', 'blusa com estampa', 15, 35),
(36, 'blusa regata branca', 'blusa regata leve com estampa', 15, 36),
(37, 'blusa bege regata', 'blusa comum regata com estampa', 20, 37),
(38, 'camiseta rosa', 'camiseta com estampa', 20, 38),
(39, 'blusa regata amarela', 'blusa leve com estampa', 15, 39),
(40, 'blusa regata rosa', 'blusa com estampa', 15, 40),
(41, 'blusa regata listrada', 'blusa com listras marrons', 20, 41),
(42, 'blusa branca', 'blusa com estampa', 15, 42),
(43, 'saia preta', 'saia curta ', 20, 43),
(44, 'blusa rosa', 'blusa com tecido leve', 20, 44),
(45, 'blusa azul clara', 'blusa curta super leve', 15, 45),
(46, 'blusa branca longa', 'blusa com estampa', 15, 46),
(47, 'blusa branca', 'blusa branca com desenhos estampados', 20, 47),
(48, 'camiseta preta', 'camiseta comum ', 10, 48),
(49, 'blusa salmon', 'blusa leve tomara que caia ', 20, 49),
(50, 'blusa regata branca', 'blusa com estampa', 15, 50),
(51, 'blusa vermelha e branca', 'blusa com listras brancas e vermelhas', 20, 51);

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `us_cod` int(6) NOT NULL,
  `us_nome` varchar(70) NOT NULL,
  `us_email` varchar(50) NOT NULL,
  `us_telefone` varchar(45) NOT NULL,
  `us_senha` varchar(45) NOT NULL,
  `us_datanascimento` date NOT NULL,
  `us_cidade` varchar(45) NOT NULL,
  `us_estado` varchar(45) NOT NULL,
  `us_rua` varchar(45) NOT NULL,
  `us_bairro` varchar(45) NOT NULL,
  `us_cep` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`us_cod`, `us_nome`, `us_email`, `us_telefone`, `us_senha`, `us_datanascimento`, `us_cidade`, `us_estado`, `us_rua`, `us_bairro`, `us_cep`) VALUES
(1, 'leonardo', 'leonardo.aguirre@etec.sp.gov.br', '1112345678', 'leo123', 0x323030302d30362d3034, 'SÃ£o paulo', 'sp', 'rua 2', 'centro', 8557000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `contato`
--
ALTER TABLE `contato`
  ADD PRIMARY KEY (`con_cod`),
  ADD UNIQUE KEY `con_cod` (`con_cod`);

--
-- Indexes for table `entrega`
--
ALTER TABLE `entrega`
  ADD PRIMARY KEY (`numero_pedido`);

--
-- Indexes for table `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`codigo`),
  ADD UNIQUE KEY `codigo` (`codigo`);

--
-- Indexes for table `produtos`
--
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`us_cod`),
  ADD UNIQUE KEY `us_cod` (`us_cod`),
  ADD UNIQUE KEY `us_email` (`us_email`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `contato`
--
ALTER TABLE `contato`
  MODIFY `con_cod` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `pedido`
--
ALTER TABLE `pedido`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `produtos`
--
ALTER TABLE `produtos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=202;
--
-- AUTO_INCREMENT for table `usuario`
--
ALTER TABLE `usuario`
  MODIFY `us_cod` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `entrega`
--
ALTER TABLE `entrega`
  ADD CONSTRAINT `entrega_ibfk_1` FOREIGN KEY (`numero_pedido`) REFERENCES `pedido` (`codigo`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
