using System;
using model;

namespace view
{
    public static class JogarView
    {
        public static void IniciarJogo()
        {
            Console.Clear();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine(" _                                    _       _     _ ");  
            Console.WriteLine("| |                                  | |     | |   (_)");
            Console.WriteLine("| |_ __ _ _ __ ___   __ _  __ _  ___ | |_ ___| |__  _ ");
            Console.WriteLine("| __/ _` | '_ ` _ \\ / _` |/ _` |/ _ \\| __/ __| '_ \\| |");
            Console.WriteLine("| || (_| | | | | | | (_| | (_| | (_) | || (__| | | | |");
            Console.WriteLine(" \\__\\__,_|_| |_| |_|\\__,_|\\__, |\\___/ \\__\\___|_| |_|_|");
            Console.WriteLine("                           __/ |                      ");
            Console.WriteLine("                          |___/                       ");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        }
        public static string setNomeJogador()
        {
            string? nomeJogador = "";
            Console.WriteLine("Olá, seja bem vindo ao meu Tamagochi de pokémon! Espero que goste. Mas deixa eu te perguntar, qual o seu nome?");
            do{
                Console.Write(": ");
                nomeJogador = Console.ReadLine();
                Console.WriteLine($"Seu nome é {nomeJogador}?[1 - SIM | 2 - NÃO]");
                Console.Write(": ");
                int opt = Convert.ToInt32(Console.ReadLine());
                if (opt == 1){
                    break;
                } else if (opt == 2){
                    Console.Clear();
                    Console.WriteLine("Qual o seu nome?");
                } else {
                    Console.Clear();
                    Console.WriteLine("Opção inválida! Por favor escolha uma opção válida!");
                    Console.WriteLine("Qual o seu nome?");
                }
            } while (true);
            Console.Clear();
            return nomeJogador!;
        }

        public static void MenuPrincipal()
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------MENU--------------------------");
            Console.WriteLine("| 1 - Adotar um mascote virtual                        |");
            Console.WriteLine("| 2 - Ver seus mascotes                                |");
            Console.WriteLine("| 0 - Sair                                             |");
            Console.WriteLine("--------------------------------------------------------");
            Console.Write("--> ");
        }
        public static void MenuAdotarMascote(IList<Pokemon> lista)
        {   
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------ADOTAR UM MASCOTE-------------------");
            for (int i = 0; i < lista.Count; i++){
                Console.WriteLine($" {i+1} - {lista[i].Name}");             
            }
            Console.WriteLine(" 0 - Voltar"); 
            Console.WriteLine("--------------------------------------------------------");
            Console.Write("--> ");
        }

        public static void MenuInspecionarMascote(Pokemon mascote, string nomeJogador){
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"{nomeJogador} você deseja:");
            Console.WriteLine($" 1 - Saber mais sobre {mascote.Name}");
            Console.WriteLine($" 2 - Adotar {mascote.Name}");
            Console.WriteLine(" 0 - Voltar");
            Console.Write("--> ");
        }

        public static void MensagemSaberMais(Pokemon mascote){
            Console.Clear();
            Console.WriteLine(mascote.ToString());
            mascote.showAbilities();
            Console.ReadKey();
        }

        public static void MensagemMascoteAdotado(Pokemon mascote)
        {
            Console.WriteLine($"Parabéns você acabou de adotar um {mascote.Name}! Por favor cuide dele direitinho.");
            Console.WriteLine("          __O__");
            Console.WriteLine("        .'     '.");
            Console.WriteLine("      .'         '.");
            Console.WriteLine("     .  _________  .");
            Console.WriteLine("     : |   .-.   | :");
            Console.WriteLine("    :  |  ( - )  |  :");
            Console.WriteLine("    :  |   ' '   |  :");
            Console.WriteLine("    :  |_________|  :");
            Console.WriteLine("     |             |");
            Console.WriteLine("     '   O     O   '");
            Console.WriteLine("      ',    O    ,'");
            Console.WriteLine("        '.......'");
            Console.WriteLine("");
            Console.ReadKey();
        }
        public static void MenuVerSeusMascotes(IList<Mascote> lista)
        {
            
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------VER SEUS MASCOTES-------------------");
            for (int i = 0; i < lista.Count; i++){
                Console.WriteLine($" {i+1} - {lista[i].Name}");             
            }
            Console.WriteLine(" 0 - Voltar");
            Console.Write("--> ");            
        }

        public static void MenuInteragirMascote(Mascote mascote){
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("-------------------------MASCOTE------------------------");
            Console.WriteLine("| O que você?                                          |");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"| 1 - Ver como {mascote.Name} está.");
            Console.WriteLine($"| 2 - Dar uma comida para {mascote.Name}.");
            Console.WriteLine($"| 3 - Brincar com {mascote.Name}.");
            Console.WriteLine($"| 4 - Colocar {mascote.Name} para dormir.");
            Console.WriteLine($"| 0 - Voltar");
            Console.WriteLine("--------------------------------------------------------");
            Console.Write("--> ");
        }

        public static void MenuEscolheBerry(IList<Berry> lista)
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("-------------------------BERRYS-------------------------");
            for (int i = 0; i < lista.Count; i++){
                Console.WriteLine($" {i+1} - {lista[i].name}");             
            }
            Console.WriteLine(" 0 - Voltar"); 
            Console.WriteLine("--------------------------------------------------------");
            Console.Write("--> ");
        }
        public static void MenuSaborBerry(Berry berry)
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("-------------------------BERRYS-------------------------");
            for (int i = 0; i < berry.flavors.Count; i++){
                Console.WriteLine($" {i+1} - {berry.flavors[i].flavor}");             
            }
            Console.WriteLine(" 0 - Voltar"); 
            Console.WriteLine("--------------------------------------------------------");
            Console.Write("--> ");
        }
    }
}
