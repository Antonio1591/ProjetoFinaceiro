using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjetoFinaceiro.Criação_banco
{
    public class Selects_de_criação_banco
    {
        public string criacaoBancoTipos =
            @"
                CREATE TABLE `projetofinaceiro`.`Tipos`(`ID` INT NOT NULL AUTO_INCREMENT,
                     `Nome` VARCHAR(45) NOT NULL,
                      `Tipo` VARCHAR(45) NOT NULL,
                      `Descricao` VARCHAR(45) NOT NULL,
                      `Situacao` VARCHAR(45) NOT NULL,
                      PRIMARY KEY (`ID`));

";
        public string criacaoBancoMovimentoFinaceiro =
              @" CREATE TABLE `projetofinaceiro`.`movimentofinaceiro` (`Id` INT NOT NULL AUTO_INCREMENT,
                      `TipoOperacao_Finaceiro` VARCHAR(45) NOT NULL,`ValorEntrada_Finaceiro` DOUBLE NOT NULL,
                      `ValorSaida_Finaceiro` DOUBLE NOT NULL,`DataMovimentacao_Finaceiro` DOUBLE NOT NULL,
                      `Situacao_Finaceiro` VARCHAR(45) NOT NULL, PRIMARY KEY (`Id`));";

        public string criacaoBancoEntradaFinaceira = @"CREATE TABLE `projetofinaceiro`.`entradafinaceira` (
                     `ID` INT NOT NULL AUTO_INCREMENT,
                     `Nome_Entrada` VARCHAR(45) NOT NULL,
                      `Valor_Entrada` DOUBLE NOT NULL,
                      `Data_Entrada` DATETIME NOT NULL,
                      `Situacao_Entrada` VARCHAR(45) NOT NULL,
                      PRIMARY KEY (`ID`));";



        public string criacaoBancoSaidaFinaceira =
                            @"CREATE TABLE `projetofinaceiro`.`Saidafinaceira` (
                     `ID` INT NOT NULL AUTO_INCREMENT,
                     `Nome_Saida` VARCHAR(45) NOT NULL,
                      `Valor_Saida` DOUBLE NOT NULL,
                      `Data_Saida` DATETIME NOT NULL,
                      `Situacao_Saida` VARCHAR(45) NOT NULL,
                      PRIMARY KEY (`ID`));

                ";

    }

}
