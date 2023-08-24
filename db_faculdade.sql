-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 17-Jun-2023 às 03:49
-- Versão do servidor: 10.4.24-MariaDB
-- versão do PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `db_faculdade`
--
CREATE DATABASE IF NOT EXISTS `db_faculdade` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `db_faculdade`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_funcionarios`
--

CREATE TABLE `tb_funcionarios` (
  `cd_funcionarios` int(11) NOT NULL,
  `nm_funcionario` varchar(25) NOT NULL,
  `dt_nascimento` datetime NOT NULL,
  `cd_genero` int(1) NOT NULL,
  `cd_contratacao` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tb_funcionarios`
--

INSERT INTO `tb_funcionarios` (`cd_funcionarios`, `nm_funcionario`, `dt_nascimento`, `cd_genero`, `cd_contratacao`) VALUES
(6, 'lucas', '0000-00-00 00:00:00', 0, 0),
(8, 'takashi', '0000-00-00 00:00:00', 0, 0),
(10, 'isabelle prates', '0000-00-00 00:00:00', 0, 0),
(18, 'diego vieira ribeiro', '0000-00-00 00:00:00', 0, 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_usuarios`
--

CREATE TABLE `tb_usuarios` (
  `cd_usuario` int(11) NOT NULL,
  `nm_usuario` varchar(10) NOT NULL,
  `cd_senha` varchar(8) NOT NULL,
  `priv_usuario` enum('admin','usuario') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf32;

--
-- Extraindo dados da tabela `tb_usuarios`
--

INSERT INTO `tb_usuarios` (`cd_usuario`, `nm_usuario`, `cd_senha`, `priv_usuario`) VALUES
(2, 'isa', '321', ''),
(4, 'izzeee', '1234', ''),
(5, 'isabelle', '12345', ''),
(6, 'Lucas', 'jubiscla', '');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `tb_funcionarios`
--
ALTER TABLE `tb_funcionarios`
  ADD PRIMARY KEY (`cd_funcionarios`);

--
-- Índices para tabela `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  ADD PRIMARY KEY (`cd_usuario`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_funcionarios`
--
ALTER TABLE `tb_funcionarios`
  MODIFY `cd_funcionarios` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT de tabela `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  MODIFY `cd_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
