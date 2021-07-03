-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 30-Maio-2017 às 03:57
-- Versão do servidor: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bd_commanager`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `agenda`
--

CREATE TABLE `agenda` (
  `Id` int(10) NOT NULL,
  `Lembrete` varchar(50) NOT NULL,
  `Nome` varchar(50) NOT NULL,
  `Visibilidade` varchar(20) NOT NULL,
  `Data` date NOT NULL,
  `Hora` varchar(10) NOT NULL,
  `Observacoes` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `agenda`
--

INSERT INTO `agenda` (`Id`, `Lembrete`, `Nome`, `Visibilidade`, `Data`, `Hora`, `Observacoes`) VALUES
(1, 'asdsadsa', 'JOÃO VITOR CARDOSO CAMARGO', 'Apenas eu posso ver', '2017-05-24', '22:25:28', 'asdsadsa'),
(2, 'asdsadasdsa', 'CAIO EDUARDO', 'Todos funcionarios', '2017-05-24', '22:29:52', 'asdsadas');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `Id` int(10) NOT NULL,
  `Nome` varchar(60) NOT NULL,
  `RG` varchar(15) NOT NULL,
  `CPF` varchar(15) NOT NULL,
  `DataNascimento` varchar(15) NOT NULL,
  `Celular` varchar(15) NOT NULL,
  `Telefone` varchar(15) NOT NULL,
  `Email` varchar(60) NOT NULL,
  `CEP` varchar(15) NOT NULL,
  `UF` varchar(3) NOT NULL,
  `Cidade` varchar(25) NOT NULL,
  `Rua` varchar(50) NOT NULL,
  `Numero` int(6) NOT NULL,
  `Bairro` varchar(30) NOT NULL,
  `Complemento` varchar(40) NOT NULL,
  `Observacoes` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`Id`, `Nome`, `RG`, `CPF`, `DataNascimento`, `Celular`, `Telefone`, `Email`, `CEP`, `UF`, `Cidade`, `Rua`, `Numero`, `Bairro`, `Complemento`, `Observacoes`) VALUES
(1, 'leonardo', '11.111.111-1', '111.111.111-11', '24/5/2017', '(11)11111-1111', '(11)1111-1111', 'ashdvsagdvgh', '08557-100', 'SP', 'poa', 'asbdhasbjh', 0, 'ashdbsahj', 'sadb', 'asdsas');

-- --------------------------------------------------------

--
-- Estrutura da tabela `despesas`
--

CREATE TABLE `despesas` (
  `Id` int(10) NOT NULL,
  `DataVencimento` date NOT NULL,
  `NomeDespesa` varchar(50) NOT NULL,
  `Valor` double(10,2) NOT NULL,
  `Observacoes` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `despesas`
--

INSERT INTO `despesas` (`Id`, `DataVencimento`, `NomeDespesa`, `Valor`, `Observacoes`) VALUES
(1, '2017-05-24', 'sadasd', 2000.00, 'asdasda');

-- --------------------------------------------------------

--
-- Estrutura da tabela `financasfuncionarios`
--

CREATE TABLE `financasfuncionarios` (
  `Id` int(10) NOT NULL,
  `Nome` varchar(50) NOT NULL,
  `ValorSalario` double(10,2) NOT NULL,
  `DataPagamento` date NOT NULL,
  `Observacoes` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `financasfuncionarios`
--

INSERT INTO `financasfuncionarios` (`Id`, `Nome`, `ValorSalario`, `DataPagamento`, `Observacoes`) VALUES
(1, 'sadsadas', 2000.00, '2017-05-24', 'asdsada');

-- --------------------------------------------------------

--
-- Estrutura da tabela `fornecedor`
--

CREATE TABLE `fornecedor` (
  `Id` int(11) NOT NULL,
  `DataCadastro` varchar(15) NOT NULL,
  `Segmento` varchar(50) NOT NULL,
  `NomeCompleto` varchar(50) NOT NULL,
  `NomeFantasia` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Rua` varchar(50) NOT NULL,
  `NumeroRua` varchar(5) NOT NULL,
  `Bairro` varchar(50) NOT NULL,
  `Cidade` varchar(50) NOT NULL,
  `UF` varchar(2) NOT NULL,
  `CEP` varchar(15) NOT NULL,
  `Telefone` varchar(20) NOT NULL,
  `Telefone2` varchar(20) NOT NULL,
  `Celular` varchar(20) NOT NULL,
  `Celular2` varchar(20) NOT NULL,
  `Complemento` varchar(15) NOT NULL,
  `NomeRepresentante` varchar(50) NOT NULL,
  `EmailRepresentante` varchar(50) NOT NULL,
  `CNPJ` varchar(15) NOT NULL,
  `IE` varchar(15) NOT NULL,
  `Observacoes` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `fornecedor`
--

INSERT INTO `fornecedor` (`Id`, `DataCadastro`, `Segmento`, `NomeCompleto`, `NomeFantasia`, `Email`, `Rua`, `NumeroRua`, `Bairro`, `Cidade`, `UF`, `CEP`, `Telefone`, `Telefone2`, `Celular`, `Celular2`, `Complemento`, `NomeRepresentante`, `EmailRepresentante`, `CNPJ`, `IE`, `Observacoes`) VALUES
(1, '4/5/2017', 'MECANICO', 'asbdb', 'sadasdasd', 'asdsadsad', 'asadsadsa', '123', 'sadsadsa', 'sadsadsa', 'SP', '20116-556', ' (11) 1111 - 1122', ' (22) 2222 - 2211', ' (22) 22222 - 2111', ' (22) 22222 - 2111', 'sadsadasd', 'sadsad', 'asdasdas', '  11.111.111/11', '016516', 'asdasdas');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionario`
--

CREATE TABLE `funcionario` (
  `Id` int(10) NOT NULL,
  `Nome` varchar(50) NOT NULL,
  `RG` varchar(15) NOT NULL,
  `CPF` varchar(15) NOT NULL,
  `DataNascimento` varchar(15) NOT NULL,
  `Celular` varchar(15) NOT NULL,
  `Telefone` varchar(15) NOT NULL,
  `Email` varchar(60) NOT NULL,
  `UF` varchar(4) NOT NULL,
  `CEP` varchar(15) NOT NULL,
  `Cidade` varchar(40) NOT NULL,
  `Rua` varchar(50) NOT NULL,
  `NumeroRua` varchar(10) NOT NULL,
  `Bairro` varchar(30) NOT NULL,
  `Complemento` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `funcionario`
--

INSERT INTO `funcionario` (`Id`, `Nome`, `RG`, `CPF`, `DataNascimento`, `Celular`, `Telefone`, `Email`, `UF`, `CEP`, `Cidade`, `Rua`, `NumeroRua`, `Bairro`, `Complemento`) VALUES
(1, 'leonardo', '11.111.111-1', '222.222.222-22', '25/5/2017', '(10)22222-2222', '(11)1111-1111', 'asdbghsadjh', 'SP', '15654-646', 'ashdbah', 'vgasvdhga', '12', 'dasdbj', 'asvdgsah'),
(2, 'joao', '22.222.222-2', '111.111.111-11', '25/5/2017', '(21)32165-4651', '(56)4654-6546', 'sadhsajdgav', 'SP', '31545-646', 'sbdasjh', 'kdbahsagsvh', '445', 'ashdbsajhv', 'ahsbd'),
(3, 'jonas', '1534656', '54654654', '15/04/2000', '4154656', '64654654', 'dabsjdvashgv', 'sa', '456468', 'sadahj', 'hjsvajdsav', 'jhdvsajvhd', 'dvagsjdv', 'gdsvahgdas');

-- --------------------------------------------------------

--
-- Estrutura da tabela `orcamentos`
--

CREATE TABLE `orcamentos` (
  `Id` int(10) NOT NULL,
  `Cliente` varchar(50) NOT NULL,
  `Vendedor` varchar(50) NOT NULL,
  `ValorItens` double(10,2) NOT NULL,
  `Desconto` double(10,2) NOT NULL,
  `ValorFrete` double(10,2) NOT NULL,
  `ValorTotal` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `orcamentos`
--

INSERT INTO `orcamentos` (`Id`, `Cliente`, `Vendedor`, `ValorItens`, `Desconto`, `ValorFrete`, `ValorTotal`) VALUES
(1, 'ABJHSA', 'leonardo', 40.00, 0.00, 20.00, 60.00);

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE `produto` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(50) NOT NULL,
  `Unidade` varchar(20) NOT NULL,
  `Marca` varchar(40) NOT NULL,
  `Categoria` varchar(30) NOT NULL,
  `Fornecedor` varchar(40) NOT NULL,
  `ValorCusto` double(10,2) NOT NULL,
  `ValorVenda` double(10,2) NOT NULL,
  `ValorFrete` double(10,2) NOT NULL,
  `Observacoes` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `produto` (`Id`, `Nome`, `Unidade`, `Marca`, `Categoria`, `Fornecedor`, `ValorCusto`, `ValorVenda`, `ValorFrete`, `Observacoes`) VALUES
(1, 'vidro', 'Unidade', 'vetro', 'vidro', '', 15.00, 20.00, 10.00, 'sagvdgsa');

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtosorcamentos`
--

CREATE TABLE `produtosorcamentos` (
  `Id` int(10) NOT NULL,
  `IdProduto` int(10) NOT NULL,
  `IdOrcamento` int(10) NOT NULL,
  `Nome` varchar(50) NOT NULL,
  `UnidadeMedida` varchar(30) NOT NULL,
  `Marca` varchar(30) NOT NULL,
  `Categoria` varchar(30) NOT NULL,
  `Valor` double(10,2) NOT NULL COMMENT 'R$00,00',
  `ValorCusto` double(10,2) NOT NULL,
  `Frete` double(10,2) NOT NULL,
  `Observacoes` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `produtosorcamentos`
--

INSERT INTO `produtosorcamentos` (`Id`, `IdProduto`, `IdOrcamento`, `Nome`, `UnidadeMedida`, `Marca`, `Categoria`, `Valor`, `ValorCusto`, `Frete`, `Observacoes`) VALUES
(3, 1, 1, 'vidro', 'Unidade', 'vetro', 'vidro', 20.00, 15.00, 10.00, 'sagvdgsa'),
(4, 1, 1, 'vidro', 'Unidade', 'vetro', 'vidro', 20.00, 15.00, 10.00, 'sagvdgsa');

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtosvendas`
--

CREATE TABLE `produtosvendas` (
  `Id` int(10) NOT NULL,
  `IdProduto` int(10) NOT NULL,
  `IdVenda` int(10) NOT NULL,
  `Nome` varchar(50) NOT NULL,
  `UnidadeMedida` varchar(30) NOT NULL,
  `Marca` varchar(30) NOT NULL,
  `Categoria` varchar(30) NOT NULL,
  `Valor` double(10,2) NOT NULL COMMENT 'R$00,00',
  `ValorCusto` double(10,2) NOT NULL,
  `Frete` double(10,2) NOT NULL,
  `Observacoes` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `produtosvendas`
--

INSERT INTO `produtosvendas` (`Id`, `IdProduto`, `IdVenda`, `Nome`, `UnidadeMedida`, `Marca`, `Categoria`, `Valor`, `ValorCusto`, `Frete`, `Observacoes`) VALUES
(2, 1, 2, 'vidro', 'Unidade', 'vetro', 'vidro', 20.00, 15.00, 10.00, 'sagvdgsa'),
(3, 1, 3, 'vidro', 'Unidade', 'vetro', 'vidro', 20.00, 15.00, 10.00, 'sagvdgsa'),
(4, 1, 3, 'vidro', 'Unidade', 'vetro', 'vidro', 20.00, 15.00, 10.00, 'sagvdgsa');

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtosvendastemporaria`
--

CREATE TABLE `produtosvendastemporaria` (
  `Id` int(10) NOT NULL,
  `IdProduto` int(10) NOT NULL,
  `Nome` varchar(50) NOT NULL,
  `UnidadeMedida` varchar(20) NOT NULL,
  `Marca` varchar(30) NOT NULL,
  `Categoria` varchar(30) NOT NULL,
  `Valor` double(10,2) NOT NULL,
  `ValorCusto` double(10,2) NOT NULL,
  `Frete` double(10,2) NOT NULL,
  `Observacoes` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `Id` int(11) NOT NULL,
  `Usuario` varchar(50) NOT NULL,
  `Senha` varchar(50) NOT NULL,
  `Nome` varchar(50) NOT NULL,
  `RG` varchar(15) NOT NULL,
  `Tipo` varchar(25) NOT NULL,
  `Email` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`Id`, `Usuario`, `Senha`, `Nome`, `RG`, `Tipo`, `Email`) VALUES
(1, 'root', '', 'usuario', '0', '', '0');

-- --------------------------------------------------------

--
-- Estrutura da tabela `vendas`
--

CREATE TABLE `vendas` (
  `Id` int(10) NOT NULL,
  `IdComprador` int(10) NOT NULL,
  `IdVendedor` int(10) NOT NULL,
  `Comprador` varchar(50) NOT NULL,
  `Vendedor` varchar(50) NOT NULL,
  `DataVenda` date NOT NULL,
  `HoraVenda` varchar(15) NOT NULL,
  `DataEntrega` varchar(15) NOT NULL,
  `HoraEntrega` varchar(15) NOT NULL,
  `Observacoes` varchar(60) NOT NULL,
  `ValorItens` double(10,2) NOT NULL,
  `Desconto` double(10,2) NOT NULL,
  `ValorFrete` double(10,2) NOT NULL,
  `ValorTotal` double(10,2) NOT NULL,
  `ValorLucro` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `vendas`
--

INSERT INTO `vendas` (`Id`, `IdComprador`, `IdVendedor`, `Comprador`, `Vendedor`, `DataVenda`, `HoraVenda`, `DataEntrega`, `HoraEntrega`, `Observacoes`, `ValorItens`, `Desconto`, `ValorFrete`, `ValorTotal`, `ValorLucro`) VALUES
(2, 0, 0, '', '', '2017-05-24', '22:16:19', '10/06/2000', '22:16:19', 'xfdxdffd', 40.00, 0.00, 20.00, 60.00, 0.00),
(3, 1, 0, 'leonardo', 'leonardo', '2017-05-26', '19:27:03', '26/5/2017', '19:27:03', 'asasdsasd', 40.00, 0.00, 20.00, 60.00, 10.00);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `agenda`
--
ALTER TABLE `agenda`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Id` (`Id`);

--
-- Indexes for table `despesas`
--
ALTER TABLE `despesas`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `financasfuncionarios`
--
ALTER TABLE `financasfuncionarios`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `fornecedor`
--
ALTER TABLE `fornecedor`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `funcionario`
--
ALTER TABLE `funcionario`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `orcamentos`
--
ALTER TABLE `orcamentos`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Id` (`Id`);

--
-- Indexes for table `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Id` (`Id`);

--
-- Indexes for table `produtosorcamentos`
--
ALTER TABLE `produtosorcamentos`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Id` (`Id`),
  ADD KEY `IdProduto` (`IdProduto`),
  ADD KEY `IdOrcamento` (`IdOrcamento`);

--
-- Indexes for table `produtosvendas`
--
ALTER TABLE `produtosvendas`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IdProduto` (`IdProduto`),
  ADD KEY `IdVenda` (`IdVenda`);

--
-- Indexes for table `produtosvendastemporaria`
--
ALTER TABLE `produtosvendastemporaria`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Id` (`Id`),
  ADD KEY `IdProduto` (`IdProduto`);

--
-- Indexes for table `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `vendas`
--
ALTER TABLE `vendas`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Id` (`Id`),
  ADD KEY `IdComprador` (`IdComprador`),
  ADD KEY `IdVendedor` (`IdVendedor`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `agenda`
--
ALTER TABLE `agenda`
  MODIFY `Id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `cliente`
--
ALTER TABLE `cliente`
  MODIFY `Id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `despesas`
--
ALTER TABLE `despesas`
  MODIFY `Id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `financasfuncionarios`
--
ALTER TABLE `financasfuncionarios`
  MODIFY `Id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `fornecedor`
--
ALTER TABLE `fornecedor`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `funcionario`
--
ALTER TABLE `funcionario`
  MODIFY `Id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `orcamentos`
--
ALTER TABLE `orcamentos`
  MODIFY `Id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `produto`
--
ALTER TABLE `produto`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `produtosorcamentos`
--
ALTER TABLE `produtosorcamentos`
  MODIFY `Id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT for table `produtosvendas`
--
ALTER TABLE `produtosvendas`
  MODIFY `Id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `produtosvendastemporaria`
--
ALTER TABLE `produtosvendastemporaria`
  MODIFY `Id` int(10) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `vendas`
--
ALTER TABLE `vendas`
  MODIFY `Id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `produtosorcamentos`
--
ALTER TABLE `produtosorcamentos`
  ADD CONSTRAINT `produtosorcamentos_ibfk_1` FOREIGN KEY (`IdProduto`) REFERENCES `produto` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `produtosorcamentos_ibfk_2` FOREIGN KEY (`IdOrcamento`) REFERENCES `orcamentos` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `produtosvendas`
--
ALTER TABLE `produtosvendas`
  ADD CONSTRAINT `produtosvendas_ibfk_1` FOREIGN KEY (`IdProduto`) REFERENCES `produto` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `produtosvendas_ibfk_2` FOREIGN KEY (`IdVenda`) REFERENCES `vendas` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Limitadores para a tabela `produtosvendastemporaria`
--
ALTER TABLE `produtosvendastemporaria`
  ADD CONSTRAINT `produtosvendastemporaria_ibfk_1` FOREIGN KEY (`IdProduto`) REFERENCES `produto` (`Id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
