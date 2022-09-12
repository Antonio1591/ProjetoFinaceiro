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
        public string criacaoBancoMovimentoFinaceiro =
             "CREATE TABLE `projetofinaceiro`.`movimentofinaceiro` (\r\n  `Id` INT NOT NULL AUTO_INCREMENT,\r\n  `TipoOperacao_Finaceiro` VARCHAR(45) NOT NULL,\r\n  `ValorEntrada_Finaceiro` DOUBLE NOT NULL,\r\n  `ValorSaida_Finaceiro` DOUBLE NOT NULL,\r\n  `ValorTotal_Finaceiro` DOUBLE NOT NULL,\r\n  `DataMovimentacao_Finaceiro` DOUBLE NOT NULL,\r\n  `Situacao_Finaceiro` VARCHAR(45) NOT NULL,\r\n  PRIMARY KEY (`Id`));";

        public string criacaoBancoEntradaFinaceira = @"CREATE TABLE `projetofinaceiro`.`entradafinaceira` (
                     `ID` INT NOT NULL AUTO_INCREMENT,
                     `Nome_Entrada` VARCHAR(45) NOT NULL,
                      `Valor_Entrada` DOUBLE NOT NULL,
                      `Data_Entrada` DATETIME NOT NULL,
                      `Situacao_Entrada` VARCHAR(45) NOT NULL,
                      PRIMARY KEY (`ID`),
                      UNIQUE INDEX `Nome_Entrada_UNIQUE` (`Nome_Entrada` ASC) VISIBLE);";



        public string criacaoBancoSaidaFinaceira =
                            @"CREATE TABLE `projetofinaceiro`.`saidafinaceira` (
                  `ID` INT NOT NULL AUTO_INCREMENT,
                  `Nome_Saida` VARCHAR(45) NOT NULL,
                  `Valor_Saida` DOUBLE NOT NULL,
                  `Data_Saida` DATETIME NOT NULL,
                  `Situacao_Saida` VARCHAR(45) NOT NULL,
                  PRIMARY KEY (`ID`),
                  UNIQUE INDEX `Nome_Saida_UNIQUE` (`Nome_Saida` ASC) VISIBLE);
                ";

    }

}
