-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 28-Nov-2016 às 20:15
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
-- Estrutura da tabela `pedido`
--

CREATE TABLE `pedido` (
  `numero_pedido` int(11) NOT NULL,
  `itens_pedido` text NOT NULL,
  `preco_pedido` decimal(10,0) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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
(2, 'blusa preta', 'tecido leve', 15, 2);

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
-- Indexes for table `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`numero_pedido`);

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
  MODIFY `numero_pedido` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `produtos`
--
ALTER TABLE `produtos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `usuario`
--
ALTER TABLE `usuario`
  MODIFY `us_cod` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
