using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.Model
{
    public class Reserva
    {

        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

             if(hospedes.Count <= Suite.Capacidade)
                {
                        Hospedes = hospedes;
                      
                }
                else
                {
                 throw new Exception("não foi possível efetuar a reserva, capacidade excedida!! ");
                }

            
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObeterQuantidadeHospedes()
        {
           int qtdHospedes= Hospedes.Count;
            return qtdHospedes;
        }

        public decimal CacularValorDiaria()
        {
            if(DiasReservados >= 10)
            {
                return Suite.ValorDiaria * DiasReservados * 0.9m;
            }

            else
                return Suite.ValorDiaria * DiasReservados;
        }
    }
}