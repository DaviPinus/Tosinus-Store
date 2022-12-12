-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 12-Dez-2022 às 05:50
-- Versão do servidor: 10.4.25-MariaDB
-- versão do PHP: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `tds`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `endereco`
--

CREATE TABLE `endereco` (
  `id_endereco` int(11) NOT NULL,
  `rua` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `bairro` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cidade` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cep` varchar(12) COLLATE utf8mb4_unicode_ci NOT NULL,
  `complemento` varchar(25) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Extraindo dados da tabela `endereco`
--

INSERT INTO `endereco` (`id_endereco`, `rua`, `bairro`, `cidade`, `cep`, `complemento`) VALUES
(20, 'Zumbi de Arapa', 'Cazebre do Brejo', 'Arapongas', '89123456', 'Casa 3'),
(21, 'Zumbi de Arapa', 'Cazebre do Brejo', 'Arapongas', '89123456', 'Casa 3'),
(22, 'Zumbi de Arapa', 'Cazebre do Brejo', 'Arapongas', '89123456', 'Casa 3'),
(23, 'a', 'd', 'c', 'b', 'e');

-- --------------------------------------------------------

--
-- Estrutura da tabela `perfil`
--

CREATE TABLE `perfil` (
  `cod_perfil` int(11) NOT NULL,
  `nome` varchar(60) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Extraindo dados da tabela `perfil`
--

INSERT INTO `perfil` (`cod_perfil`, `nome`) VALUES
(1, 'Admin'),
(2, 'Aluno');

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE `produto` (
  `cod_produto` int(11) NOT NULL,
  `descricao` varchar(60) COLLATE utf8mb4_unicode_ci NOT NULL,
  `data_validade` datetime NOT NULL,
  `preco` decimal(7,2) NOT NULL,
  `qtde` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `produto` (`cod_produto`, `descricao`, `data_validade`, `preco`, `qtde`) VALUES
(1, 'coca cola', '2023-02-23 00:00:00', '5.60', 120),
(2, 'coca cola', '2024-03-07 00:00:00', '5.70', 20),
(3, 'pizza calabreza', '2022-11-17 00:00:00', '8.50', 5);

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto_foto`
--

CREATE TABLE `produto_foto` (
  `cod_foto` int(11) NOT NULL,
  `caminho` varchar(60) COLLATE utf8mb4_unicode_ci NOT NULL,
  `cod_produto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Extraindo dados da tabela `produto_foto`
--

INSERT INTO `produto_foto` (`cod_foto`, `caminho`, `cod_produto`) VALUES
(1, 'C:\\Users\\Aluno\\Downloads\\coca.png', 1),
(2, 'C:\\Users\\Aluno\\Downloads\\coca.jpg', 2),
(3, 'C:\\Users\\Aluno\\Downloads\\pizzacalabreza.jpg', 3);

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `usercode` int(5) NOT NULL,
  `nome` varchar(60) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(60) COLLATE utf8mb4_unicode_ci NOT NULL,
  `datanasc` date NOT NULL,
  `login` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `senha` varchar(40) COLLATE utf8mb4_unicode_ci NOT NULL,
  `perfil` varchar(9) COLLATE utf8mb4_unicode_ci NOT NULL,
  `id_endereco` int(11) NOT NULL,
  `cod_perfil` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`usercode`, `nome`, `email`, `datanasc`, `login`, `senha`, `perfil`, `id_endereco`, `cod_perfil`) VALUES
(1, 'Nome User', 'Email', '0000-00-00', 'Login', 'Senha', 'Perfil', 0, 0),
(5, 'Rafael Eduardo Tosin', 'TheTosinnus', '2005-07-16', 'Tozin', 'Tosin123', '1', 9, 0),
(7, 'Davi Pinus ', 'davisgamer69@gmail.com', '2005-04-04', 'Sivad', '123', '', 18, 0),
(8, 'Cesar Stati', 'cesarstati@gmail.com', '1977-09-17', 'Stati', '123', '', 19, 0),
(9, 'Davi', 'davi@gmail.com', '2022-12-12', 'pinus', '123', '', 20, 0),
(10, 'Davi Dois', 'davi@gmail.com', '2022-12-12', 'pinusdois', '123', '', 21, 0),
(11, 'Davi Dois', 'davi@gmail.com', '2022-12-12', 'pinusdois', '123', '', 22, 0),
(12, 'Admin', 'admin@gmail.com', '2022-12-12', 'admin', '123', '', 23, 0);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `endereco`
--
ALTER TABLE `endereco`
  ADD PRIMARY KEY (`id_endereco`);

--
-- Índices para tabela `perfil`
--
ALTER TABLE `perfil`
  ADD PRIMARY KEY (`cod_perfil`);

--
-- Índices para tabela `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`cod_produto`);

--
-- Índices para tabela `produto_foto`
--
ALTER TABLE `produto_foto`
  ADD PRIMARY KEY (`cod_foto`);

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`usercode`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `endereco`
--
ALTER TABLE `endereco`
  MODIFY `id_endereco` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT de tabela `produto`
--
ALTER TABLE `produto`
  MODIFY `cod_produto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `produto_foto`
--
ALTER TABLE `produto_foto`
  MODIFY `cod_foto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `usercode` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
