// NC temque ser maior ou igual que 1 e menor ou igual que 1000
// N indica  o numero de comandos emitidos
using System;

namespace Prova3ExerciciosAcademiadoProgramador_2.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool resp;
            do
            {

                char graus = 'N';
                char grauscorreto = 'N';
                string comando;
                int qtdcomandos = 0;

                Console.Write("Quantidade de comandos passado pelo Sargento: ( 1 ou 2 ) ");
                qtdcomandos = Convert.ToInt16(Console.ReadLine());

                Console.Write("Digite as isntruções do robô (E - Girar para a esquerda | D - Girar para a direita): ");
                comando = Convert.ToString(Console.ReadLine());

                char[] instrucoes = comando.ToCharArray();

                for (int i = 0; i < instrucoes.Length; i++)
                {
                    while (instrucoes[i] == 'E')
                    {
                        switch (graus)
                        {
                            case 'N':
                                grauscorreto = 'O';
                                if (qtdcomandos == 2)
                                {
                                    grauscorreto = 'S';
                                }
                                break;
                            case 'S':
                                grauscorreto = 'S';
                                if (qtdcomandos == 2)
                                {
                                    grauscorreto = 'L';
                                }
                                break;
                            case 'L':
                                grauscorreto = 'L';
                                if (qtdcomandos == 2)
                                {
                                    grauscorreto = 'N';
                                }
                                break;
                            case 'O':
                                grauscorreto = 'N';
                                if (qtdcomandos == 2)
                                {
                                    grauscorreto = 'O';
                                }
                                break;
                            default:
                                Console.WriteLine("Opção Invalida para o Robo! ");
                                break;
                        }
                        break;
                    }
                    while (instrucoes[i] == 'D')
                    {
                        switch (graus)
                        {
                            case 'N':
                                grauscorreto = 'L';
                                if (qtdcomandos == 2)
                                {
                                    grauscorreto = 'S';
                                }
                                break;
                            case 'S':
                                grauscorreto = 'S';
                                if (qtdcomandos == 2)
                                {
                                    grauscorreto = 'O';
                                }
                                break;
                            case 'L':
                                grauscorreto = 'O';
                                if (qtdcomandos == 2)
                                {
                                    grauscorreto = 'N';
                                }
                                break;
                            case 'O':
                                grauscorreto = 'N';
                                if (qtdcomandos == 2)
                                {
                                    grauscorreto = 'L';
                                }
                                break;
                            default:
                                Console.WriteLine("Opção Invalida para o Robo! ");
                                break;
                        }
                        break;
                    }
                    
                }

                Console.WriteLine("Foram utilizados " + qtdcomandos + " Comando!");
                Console.WriteLine("Ficou virado para: " + grauscorreto + " (N - Norte | S- Sul | L - Leste | O - Oeste)");

                Console.Write("Fazer o processo novamente ? ( para continuar digite - S ) ");
                char retornar = Convert.ToChar(Console.ReadLine());

                resp = retornar == 'S';

                //consegui apenas fazer a primeira parte sozinho a parte do switch o Pedro Nunes me ajudou muito

            } while (resp == true);
        }
    }
}
