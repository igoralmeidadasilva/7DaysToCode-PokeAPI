using System;
using AutoMapper;
using model;
using service;
using utils;
using view;

namespace controller
{
    public class JogarController
    {
        private string nomeJogador = "";
        private IList<Pokemon> listaMascote;
        private IList<Mascote> listaAdotados = new List<Mascote>();
        private IList<Berry> listaBerry = new List<Berry>();

        public JogarController()
        {
            JogarView.IniciarJogo();
            listaMascote = ServiceTamagochi.getListaMascote();
            listaBerry = ServiceTamagochi.getListaBerry();
            nomeJogador = JogarView.setNomeJogador();
            int opt = 0;
            do{
                JogarView.MenuPrincipal();
                opt = Convert.ToInt32(Console.ReadLine());
                switch(opt){
                    case 1:
                        OpcaoAdotar();
                        Console.Clear();
                        break;

                    case 2:
                        OpcaoVerSeusMascotes();
                        Console.Clear();
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Por favor, escolha uma opção válida!");
                        Console.Clear();
                        break;
                }
            } while (opt != 0);
        }

        private void OpcaoAdotar()
        {
            int opt = 0;
            do{
                JogarView.MenuAdotarMascote(listaMascote);
                opt = Convert.ToInt32(Console.ReadLine());
                if((opt != 0) && (opt <= listaMascote.Count)){
                    OpcaoInspecionarMascote(listaMascote[opt-1], nomeJogador);
                 }

            } while (opt != 0);
        }

        private void OpcaoInspecionarMascote(Pokemon mascote, string nomeJogador)
        {
            int opt = 0;
            do{
                JogarView.MenuInspecionarMascote(mascote, nomeJogador);
                opt = Convert.ToInt32(Console.ReadLine());

                switch(opt){
                    case 1:
                        JogarView.MensagemSaberMais(mascote);
                        break;
                    case 2:
                        OpcaoMascoteAdotado(mascote);
                        JogarView.MensagemMascoteAdotado(mascote);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Por favor, escolha uma opção válida!");
                        Console.ReadKey();
                        break;
                }
            } while(opt != 0);
        }

        private void OpcaoVerSeusMascotes()
        {
            int menu = 0;

            do{
                JogarView.MenuVerSeusMascotes(listaAdotados);
                menu = Convert.ToInt32(Console.ReadLine());
                if((menu != 0) && (menu <= listaAdotados.Count)){
                    //Alterar aqui para ir para outro menu, este if é o equivalente a um switch
                    OpcaoInteragirMascote(listaAdotados[menu-1]);
                    //JogarView.MenuInteragirMascote(listaAdotados[menu-1]);
                    
                }
            } while (menu != 0);
        }

        private void OpcaoMascoteAdotado(Pokemon pokemon)
        {
            //Implementar o Mapper aqui
            var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            var mapper = config.CreateMapper();
            var mascote = mapper.Map<Mascote>(pokemon);
            listaAdotados.Add(mascote);
        }
        private void OpcaoInteragirMascote(Mascote mascote)
        {
            int menu = 0;
            do{
                JogarView.MenuInteragirMascote(mascote);
                menu = Convert.ToInt32(Console.ReadLine());
                switch(menu){
                    case 1:
                        mascote.Status();
                        Console.ReadKey();
                        break;
                    case 2:
                        mascote.Comer(OpcaoBerry());
                        Console.ReadKey();
                        break;
                    case 3:
                        mascote.Brincar();
                        Console.ReadKey();
                        break;
                    case 4:
                        mascote.Dormir();
                        Console.ReadKey();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Por favor, escolha uma opção válida!");
                        Console.ReadKey();
                        break;
                }
            }while(menu != 0);
        }

        private Berry OpcaoBerry()
        {
            Berry retorno = new Berry();
            int menu = 0;
            do{
                JogarView.MenuEscolheBerry(listaBerry);
                menu = Convert.ToInt32(Console.ReadLine());
                if((menu != 0) && (menu <= listaBerry.Count)){
                    retorno = listaBerry[menu-1];
                    retorno.estadoDestaBerry = OpcaoSaborBerry(retorno);
                } 
            } while (menu != 0);

            return retorno;
        }

        private EstadoBerry OpcaoSaborBerry(Berry berry)
        {  
            EstadoBerry retorno = new EstadoBerry();
            int menu = 0;
            do{
                JogarView.MenuSaborBerry(berry);
                menu = Convert.ToInt32(Console.ReadLine());
                if((menu != 0) && (menu <= berry.flavors.Count)){
                    retorno = berry.flavors[menu-1].flavor;
                }
            } while (menu != 0);
            return retorno;
        }
    }
}
