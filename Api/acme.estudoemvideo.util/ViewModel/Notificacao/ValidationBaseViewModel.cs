using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Notificacao
{
    public static class ValidationBaseViewModel
    {
        public static string Mensagem(this bool isValid, string mensagem)
        {
            return !isValid ? string.Format("") : string.Format(mensagem);
        }

        public static bool IsNull(this string source)
        {
            return (source is null);
        }
        public static bool IsNull(this long? source)
        {
            return (source is null);
        }

        public static bool IsNull(this DateTime? vazia)
        {
            return vazia is null;
        }

        public static bool EqualsLength(this int tamanhoTotal, int maxLength)
        {
            return tamanhoTotal == maxLength;
        }
        public static bool MaxLength(this int tamanhoTotal, int maxLength)
        {
            return tamanhoTotal > maxLength;
        }
        public static bool MinLength(this int tamanhoTotal, int minLength)
        {
            return tamanhoTotal < minLength;
        }
        public static bool DataNascimentoValida(this DateTime dataDeNascimento)
        {
            if ((DateTime.Now.Year - dataDeNascimento.Year) > 18)
            {
                return true;
            }
            if ((DateTime.Now.Year - dataDeNascimento.Year) == 18)
            {
                if (DateTime.Now.Month > dataDeNascimento.Month)
                {
                    return true;
                }
                else if (DateTime.Now.Month == dataDeNascimento.Month)
                {
                    if (DateTime.Now.Day >= dataDeNascimento.Day)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool IsMenorIgualZero(this long valor)
        {
            return valor <= 0;
        }
        public static bool IsMaiorIgualZero(this long valor)
        {
            return valor >= 0;
        }
        public static bool IsMenorIgualZero(this long? valor)
        {
            return valor <= 0;
        }
        public static bool IsPositivo(this decimal valor)
        {
            return valor > 0;
        }
        public static bool IsPositivoOrZero(this decimal valor)
        {
            return valor >= 0;
        }
        public static bool IsMaiorZero(this decimal valor)
        {
            return valor > 0;
        }
        public static bool IsNegativo(this decimal valor)
        {
            return valor < 0;
        }
        public static bool IsMenorIgualZero(this decimal valor)
        {
            return valor <= 0;
        }

        public static bool CpfValido(this string cpf)
        {
            bool isValido = false;
            if (cpf.Length != 11)
            {
                return isValido;
            }
            var itemCpf = cpf.ToCharArray();

            int somatorioMultiplicacaoPrimeiroDigito = 0;
            int j = 10;
            for (int i = 0; i < 9; i++)
            {
                somatorioMultiplicacaoPrimeiroDigito += (int.Parse(itemCpf[i].ToString()) * j);
                j--;
            }
            int divisaoPrimeiroDigito = (somatorioMultiplicacaoPrimeiroDigito / 11);
            int restoDaDivisao = somatorioMultiplicacaoPrimeiroDigito % 11;
            int primeiroDigito = restoDaDivisao < 2 ? 0 : (11 - restoDaDivisao);

            int somatorioMultiplicacaoSegundoDigito = 0;
            j = 11;
            for (int i = 0; i < 10; i++)
            {
                somatorioMultiplicacaoSegundoDigito += i == 9 ? (primeiroDigito * j) : (int.Parse(itemCpf[i].ToString()) * j);
                j--;
            }
            int divisaoSegundoDigito = (somatorioMultiplicacaoSegundoDigito / 11);
            int restoDaDivisaoSegundoDigito = somatorioMultiplicacaoSegundoDigito % 11;
            int segundoDigito = restoDaDivisaoSegundoDigito < 2 ? 0 : (11 - restoDaDivisaoSegundoDigito);

            isValido = (primeiroDigito == int.Parse(itemCpf[9].ToString())) && segundoDigito == int.Parse(itemCpf[10].ToString());
            return isValido;
        }

        public static bool CnpjValido(this string cnpjValido)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            bool isValido = false;
            if (cnpjValido.Length != 14)
            {
                return isValido;
            }
            var itemCnpj = cnpjValido.ToCharArray();

            int somatorioMultiplicacaoPrimeiroDigito = 0;
            int j = 13;
            for (int i = 0; i < 12; i++)
            {
                somatorioMultiplicacaoPrimeiroDigito += (int.Parse(itemCnpj[i].ToString()) * multiplicador1[i]);
                j--;
            }
            int divisaoPrimeiroDigito = (somatorioMultiplicacaoPrimeiroDigito / 11);
            int restoDaDivisao = somatorioMultiplicacaoPrimeiroDigito % 11;
            int primeiroDigito = restoDaDivisao < 2 ? 0 : (11 - restoDaDivisao);

            int somatorioMultiplicacaoSegundoDigito = 0;
            j = 14;
            for (int i = 0; i < 13; i++)
            {
                somatorioMultiplicacaoSegundoDigito += i == 12 ? (primeiroDigito * j) : (int.Parse(itemCnpj[i].ToString()) * multiplicador2[i]);
                j--;
            }
            int divisaoSegundoDigito = (somatorioMultiplicacaoSegundoDigito / 11);
            int restoDaDivisaoSegundoDigito = somatorioMultiplicacaoSegundoDigito % 11;
            int segundoDigito = restoDaDivisaoSegundoDigito < 2 ? 0 : (11 - restoDaDivisaoSegundoDigito);

            isValido = (primeiroDigito == int.Parse(itemCnpj[12].ToString())) && segundoDigito == int.Parse(itemCnpj[13].ToString());
            return isValido;
        }


        public static bool IsNotNull(this DateTime? vazia)
        {
            return !(vazia is null);
        }
        public static bool IsNotNull(this string source)
        {
            return !(source.IsNull());
        }
        public static bool IsNotNull(this long? source)
        {
            return !(source is null);
        }


        public static bool IsStringEmpty(this string vazia)
        {
            return string.IsNullOrEmpty(vazia);
        }
        public static bool IsStringNotEmpty(this string vazia)
        {
            return !(string.IsNullOrEmpty(vazia));
        }

    }
}
