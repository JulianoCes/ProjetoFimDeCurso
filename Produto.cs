using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MASYEV1
{
    class Produto
    {
        public Produto()
        {

        }

        public Produto(int Id, char codigo, char tipo, char nome, float quantidade, decimal valor, char usuario, decimal valortotal, DateTime datavenda)
        {
            this.p_Id = Id;
            this.p_codigo = codigo;
            this.p_tipo = tipo;
            this.p_nome = nome;
            this.p_quantidade = quantidade;
            this.p_valor = valor;
            this.p_usuario = usuario;
            this.p_valortotal = valortotal;
            this.p_datavenda = datavenda;
        }

        private int p_Id = 0;
        private char? p_codigo = null ;
        private char? p_tipo = null;
        private char? p_nome = null;
        private float p_quantidade = 0;
        private decimal p_valor =0;
        private char? p_usuario = null;
        private decimal p_valortotal = 0;
        private DateTime? p_datavenda = null ;

        public int ID
        {
            get { return p_Id; }
            set { p_Id = value; }
        }

        public char? Codigo
        {
            get { return p_codigo; }
            set { p_codigo = value; }
        }

        public char? Tipo
        {
            get { return p_tipo; }
            set { p_tipo = value; }
        }

        public char? Nome
        {
            get { return p_nome; }
            set { p_nome = value; }
        }

        public float Quantidade
        {
            get { return p_quantidade; }
            set { p_quantidade = value; }
        }

        public decimal Valor
        {
            get { return p_valor; }
            set { p_valor = value; }
        }

        public char? Usuario
        {
            get { return p_usuario; }
            set { p_usuario = value; }
        }

        public decimal Valor_Total
        {
            get { return p_valortotal; }
            set { p_valortotal = value; }
        }

        public DateTime Data_venda
        {
            get { return (DateTime) p_datavenda; }
            set { p_datavenda = value; }
        }
    }
}
