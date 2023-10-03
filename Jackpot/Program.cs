using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.RegularExpressions;

namespace programa_CASINO
{
    class Program
    {
        static void Main(string[] args)
        {
          
        intro_jackpot();
        
        }
        private static void intro_jackpot()
        {
            string title = @"
                                            ░░░░░██╗░█████╗░░█████╗░██╗░░██╗██████╗░░█████╗░████████╗
                                            ░░░░░██║██╔══██╗██╔══██╗██║░██╔╝██╔══██╗██╔══██╗╚══██╔══╝
                                            ░░░░░██║███████║██║░░╚═╝█████═╝░██████╔╝██║░░██║░░░██║░░░
                                            ██╗░░██║██╔══██║██║░░██╗██╔═██╗░██╔═══╝░██║░░██║░░░██║░░░
                                            ╚█████╔╝██║░░██║╚█████╔╝██║░╚██╗██║░░░░░╚█████╔╝░░░██║░░░
                                            ░╚════╝░╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝╚═╝░░░░░░╚════╝░░░░╚═╝░░░";

            for (int e = 0; e < 5; e++)
            {

                switch (e)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(title);
                        Thread.Sleep(200);
                        Console.Clear();

                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(title);
                        Thread.Sleep(200);
                        Console.Clear();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(title);
                        Thread.Sleep(200);
                        Console.Clear();

                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(title);
                        Thread.Sleep(200);
                        Console.Clear();

                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(title);
                        Thread.Sleep(200);
                        Console.Clear();

                        break;
                }
            }
            Console.CursorVisible = false;
            Console.WriteLine("Bienvenido a Jackpot, por favor introduce tu nombre");
            string nombre_usuario_jackpot = Console.ReadLine();
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Hola, {nombre_usuario_jackpot}, bienvenido/a a Jackpot!\n"); inicio:
            Console.WriteLine("Quieres ver las instrucciones del juego o deseas pasar directamente a jugar?");

            ConsoleKeyInfo tecla;

            Console.WriteLine("(X) Ver instrucciones\n(Z) Ir a Jugar\n(Y) Salir del juego ");
            tecla = Console.ReadKey();

            switch (tecla.Key)
            {
                case ConsoleKey.X:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(@"
                                    █ █▄░█ █▀ ▀█▀ █▀█ █░█ █▀▀ █▀▀ █ █▀█ █▄░█ █▀▀ █▀
                                    █ █░▀█ ▄█ ░█░ █▀▄ █▄█ █▄▄ █▄▄ █ █▄█ █░▀█ ██▄ ▄█");
                    Console.Write("\n\nLa ruleta del Jackpot cuenta con 9 numeros del 1 - 9. Entre ellos hay 3 numeros de la suerte, el 7, 3, 9."
                    + "\n- El patron de 3 lineas del numero 7 con un premio de 2,200 fichas."
                    + "\n- El patron de 3 lineas del numero 3 triplicara el valor de fichas que posee el jugador."
                    + "\n- El patron de 3 lineas del numero 9 regala 20 fichas.\n\n");

                    Console.WriteLine("\nPresiona una tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine(@"
     █▄─░█ █──█ █▀▄▀█ █▀▀ █▀▀█ █▀▀█ 　 █▀▀▄ █▀▀ 　 █── █▀▀█ 　 █▀▀ █──█ █▀▀ █▀▀█ ▀▀█▀▀ █▀▀ ▄ 　 ▀▀▀█ 
     █░█░█ █──█ █─▀─█ █▀▀ █▄▄▀ █──█ 　 █──█ █▀▀ 　 █── █▄▄█ 　 ▀▀█ █──█ █▀▀ █▄▄▀ ──█── █▀▀ ─ 　 ──█─ 
     █──▀█ ─▀▀▀ ▀───▀ ▀▀▀ ▀─▀▀ ▀▀▀▀ 　 ▀▀▀─ ▀▀▀ 　 ▀▀▀ ▀──▀ 　 ▀▀▀ ─▀▀▀ ▀▀▀ ▀─▀▀ ──▀── ▀▀▀ ▀ 　 ─▐▌─");
                    Console.WriteLine("\n\nOtros numeros de la suerte:\n- 3 (se triplica el monto). \n- 9 (se gana 100 fichas más)\n\n");

                    Console.WriteLine("\nPresiona una tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine(@"
    █▀▀ █▀█ █▀▄▀█ █▀█ █▀▄ █ █▄░█ █▀▀ █▀
    █▄▄ █▄█ █░▀░█ █▄█ █▄▀ █ █░▀█ ██▄ ▄█" + "\n\n");
                    Console.WriteLine("El juego consta con 3 comodines:\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@"                                                                                                 
                    ◄██▄                                                                        
                        ████                                 
                            ████                               
                             █████                                                   
                         ██ ██████▄▄▄▀▀▀███▄►                    
                       ██  ██ ██ ██                               
                      ██   ███  ███                              
                     █     █ ████ █                              
                     ▼      █    █                               
                             ████                                
                                    ");

                    Console.Write("\n- Bufon : se restan 20 fichas.\n");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"                                                                                             
                                                            
                             ▓                                      
                            ▓▓▓                                     
                           ▓▓▓▓▓                                    
                         ▓  ▓▓▓  ▓                                  
                        ▓▓▓▓▓▓▓▓▓▓▓                                 
                       ▓▓▓▓▓▓▓▓▓▓▓▓▓                                
                        ▓▓▓ ▓▓▓ ▓▓▓                                 
                         ▓ ▓▓▓▓▓ ▓                                  
                            ▓▓▓                                     
                             ▓                                      
                                   ");

                    Console.Write("\n- Trebol de 4 hojas: 10 fichas gratis\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(@"                                                                                        
                                                            
                         ██████                                 
                        █▒▒▒▒▒▒█                                                              
                        █▒▒▒▒▒▒█                                
                        █▒▒▒▒▒▒█                                
                         ██████                                 
                           ██                                   
                           ██                                   
                           ██                                                                
                               ");
                    Console.Write("\n- Espejo: equivale a cualquier numero faltante.\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    inicio2:
                    Console.WriteLine("Presiona enter para continuar al juego\n");

                    if ((tecla = Console.ReadKey(true)).Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        jackpot();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Tecla invalida");
                        Thread.Sleep(3000);
                        goto inicio2;

                    }

                    break;
                case ConsoleKey.Z:
                    Thread.Sleep(1000);
                    Console.Clear();
                    jackpot();
                    break;
                case ConsoleKey.Y:
                    Thread.Sleep(1000);
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Por favor introduce una de las opciones disponibles");
                    Thread.Sleep(3000);
                    Console.Clear();
                    goto inicio;
            }

            Console.ReadKey();
        }

        private static void jackpot()
        {
            bool on = true;
            while (on)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.CursorVisible = false;
                string titulo = @"               
                  █ ▄▀█ █▀▀ █▄▀ █▀█ █▀█ ▀█▀
                █▄█ █▀█ █▄▄ █ █ █▀▀ █▄█  █ ";

                string[] items_jackspot = { @"
                          ███╗
                         ████║
                        ██╔██║
                        ╚═╝██║
                        ███████╗
                        ╚══════╝", @"
                        ██████╗
                        ╚════██╗
                          ███╔═╝
                        ██╔══╝
                        ███████╗
                        ╚══════╝", @"
                        ██████╗
                        ╚════██╗
                        █████╔╝
                        ╚═══██╗
                        ██████╔╝
                        ╚═════╝ ", @"
                        ██╗  ██╗
                        ██╔╝ ██║
                        ██╔╝ ██║
                        ███████║
                        ╚════██║
                            ╚═╝", @"
                        ███████╗
                        ██╔════╝
                        ██████╗
                        ╚════██╗
                        ██████╔╝
                        ╚═════╝", @"
                         █████╗
                        ██╔═══╝
                        ██████╗
                        ██╔══██╗
                        ╚█████╔╝
                         ╚════╝ ", @"
                        ███████╗
                        ╚════██║
                            ██╔╝
                            ██╔╝
                            ██╔╝
                            ╚═╝", @"
                          █████╗ 
                        ██╔══██╗
                        ╚█████╔╝
                        ██╔══██╗
                        ╚█████╔╝
                         ╚════╝", @"
                          █████╗
                        ██╔══██╗
                        ╚██████║
                         ╚═══██║
                         █████╔╝
                         ╚════╝ ", @"                                                                                                 
                    ◄██▄                                                                        
                        █████                                                         
                           ███████                                                   
                         ██ ██████▄▀▀▀███▄►                    
                       ██  ██ ██ ██                               
                      ██   ███  ███                              
                     █     █ ████ █                              
                     ▼      █    █                               
                             ████                                
                                    ", @"                                                                                                                         
                                     
                            ▓▓▓                                     
                           ▓▓▓▓▓                                    
                         ▓  ▓▓▓  ▓                                  
                        ▓▓▓▓▓▓▓▓▓▓▓                                 
                       ▓▓▓▓▓▓▓▓▓▓▓▓▓                                
                        ▓▓▓ ▓▓▓ ▓▓▓                                 
                         ▓ ▓▓▓▓▓ ▓                                  
                            ▓▓▓                                                                         
                                   ", @"                                                                                        
                                                            
                         ██████                                 
                        █▒▒▒▒▒▒█                                                              
                        █▒▒▒▒▒▒█                                
                        █▒▒▒▒▒▒█                                
                         ██████                                 
                           ██                                   
                           ██                                                                                                 
                               " };

                //CREACION DE LOS SIMBOLOS ALEATORIOS
                Random random_1 = new Random();
                int aleatorio_1 = random_1.Next(items_jackspot.Length);

                Random random_2 = new Random();
                int aleatorio_2 = random_1.Next(items_jackspot.Length);

                Random random_3 = new Random();
                int aleatorio_3 = random_1.Next(items_jackspot.Length);


                int billetera = 7000;
                ConsoleKeyInfo tecla;
                int fichas = 0;

                int contador_ganancias = 0;
            inicio1:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(titulo + "\n\n");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"
█▀▀ █ █▀▀ █░█ ▄▀█ █▀ ▀
█▀░ █ █▄▄ █▀█ █▀█ ▄█ ▄" + " \t" + fichas);

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\n ♣ Para girar el jackpot presiona 2 veces "); Console.ForegroundColor = ConsoleColor.Red; Console.Write(" Z \n");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\n ♣: Cada giro vale "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("10 fichas");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\t \t♣: 5 fichas valen ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("$90 monedas.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\t \t♣: El jugador solo puede comprar");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" 100 fichas");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\t \t♣: Para salir del juego presione 3 veces"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(" K");


                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\n\n█████████████████████████████████████████████████████████████████████████████████████\n");

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.Write($"{items_jackspot[aleatorio_1]}\n");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{items_jackspot[aleatorio_2]}\n");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{items_jackspot[aleatorio_3]}\n");

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("█████████████████████████████████████████████████████████████████████████████████");


                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n" + @"
    █▀ █░█ █▀█ █▀█
    ▄█ █▀█ █▄█ █▀▀");


                Console.Write("\n\n  $90 |Comprar ficha (X)\n\n");


                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"  Billetera: ${billetera}");
                int decremento = 0;

                fichas:
                if (fichas <= 100)
                {
                    if ((tecla = Console.ReadKey(true)).Key == ConsoleKey.X)
                    {
                        decremento -= 90;
                        fichas += 4;
                        Console.ForegroundColor = ConsoleColor.Green;
                        billetera = billetera + decremento;
                        Console.Clear();
                        goto inicio1;
                    }
                    if ((tecla = Console.ReadKey(true)).Key == ConsoleKey.Z)
                    {
                        goto spin_true;

                    }
                    else if ((tecla = Console.ReadKey(true)).Key == ConsoleKey.K)
                    {
                        Console.Clear();
                        Console.WriteLine("Cerrando juego...");
                        Thread.Sleep(3000);
                        Console.Clear();
                        on = false;
                    }
                    else
                    {
                        Console.Clear();
                        goto inicio1;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("  Haz llegado al limite de compra!!!");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nPara comenzar el jackpot presiona Z\n");
                    Console.ForegroundColor = ConsoleColor.Red; Console.Write(@"                                                            

                               ████████                        
                              █░░░░░░███                       
                             ███████░████                      
                             ██████░█████                      
                             █████░██████                      
                              ███░░░░░░█                       
                               █▓██████                        
                               ▓▓                              
                              ▓▓                               
                        █████▓▓                                
                        ████▓▓█                                
                        ███▓▓██                                
                        ██▓▓███                                
                        ███████                                
                                       ");
                    billetera += 4;
                    fichas = 100;
                    goto fichas;

                }



                if ((tecla = Console.ReadKey(true)).Key == ConsoleKey.Z)
                {

                    goto spin_true;
                }

            spin_true:
                bool jackspot_spin = true;
                if (fichas > 9)
                {
                    fichas -= 10;
                    while (jackspot_spin)
                    {
                        for (int e = 0; e < items_jackspot.Length; e++)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(titulo);
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\n\n█████████████████████████████████████████████████████████\n");

                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write($"{items_jackspot[aleatorio_1]}\n");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"{items_jackspot[aleatorio_2]}\n");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write($"{items_jackspot[aleatorio_3]}\n");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("██████████████████████████████████████████████████████████");

                            aleatorio_1 = random_1.Next(items_jackspot.Length);
                            aleatorio_2 = random_1.Next(items_jackspot.Length);
                            aleatorio_3 = random_1.Next(items_jackspot.Length);


                            Thread.Sleep(150);


                            Console.Clear();

                        }
                        if (aleatorio_1 == 6 && aleatorio_2 == 6 && aleatorio_3 == 6)
                        {
                            contador_ganancias += 2200;
                            billetera += contador_ganancias;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t\t\t█ Ha ganado $2,200 █");



                        }
                        else if (aleatorio_1 == 2 && aleatorio_2 == 2 && aleatorio_3 == 2)
                        {
                            contador_ganancias += fichas * 3;
                            billetera += contador_ganancias;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\n\n\t\t\t\t\t\t\t\t\t\t█ Ha ganado ${fichas * 3} █");

                        }
                        else if (aleatorio_1 == 8 && aleatorio_2 == 8 && aleatorio_3 == 8)
                        {
                            fichas += 20;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t\t\t█ Ha ganado 20 fichas █");
                        }

                        //caso espejo 7
                        else if (aleatorio_1 == 11 && aleatorio_3 == 6 && aleatorio_2 == 6)
                        {
                            contador_ganancias += 2200;
                            billetera += contador_ganancias;

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nHa ganado $2,200 \n");
                        }
                        else if (aleatorio_1 == 6 && aleatorio_3 == 6 && aleatorio_2 == 11)
                        {
                            contador_ganancias += 2200;
                            billetera += contador_ganancias;

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nHa ganado $2,200 \n");

                        }
                        else if (aleatorio_1 == 6 && aleatorio_3 == 11 && aleatorio_2 == 6)
                        {
                            contador_ganancias += 2200;
                            billetera += contador_ganancias;

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nHa ganado $2,200 \n");
                        }

                        //caso espejo 3
                        else if (aleatorio_1 == 2 && aleatorio_2 == 2 && aleatorio_3 == 11)
                        {
                            contador_ganancias += fichas * 3;
                            billetera += contador_ganancias;

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\n\n\t\t\t\t\t\t\t\t\t\t█ Ha ganado ${fichas * 3} █");
                        }
                        else if (aleatorio_1 == 2 && aleatorio_2 == 11 && aleatorio_3 == 2)
                        {
                            contador_ganancias += fichas * 3;
                            billetera += contador_ganancias;

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\n\n\t\t\t\t\t\t\t\t\t\t█ Ha ganado ${fichas * 3} █");
                        }
                        else if (aleatorio_1 == 11 && aleatorio_2 == 2 && aleatorio_3 == 2)
                        {
                            contador_ganancias += fichas * 3;
                            billetera += contador_ganancias;

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\n\n\t\t\t\t\t\t\t\t\t\t█ Ha ganado ${fichas * 3} █");
                        }

                        //caso espejo 9
                        else if (aleatorio_1 == 11 && aleatorio_3 == 8 && aleatorio_2 == 8)
                        {
                            fichas += 20;

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t\t\t█ Ha ganado 20 fichas █");
                        }
                        else if (aleatorio_1 == 8 && aleatorio_3 == 8 && aleatorio_2 == 11)
                        {
                            fichas += 20;

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t\t\t█ Ha ganado 20 fichas █");
                        }
                        else if (aleatorio_1 == 8 && aleatorio_3 == 11 && aleatorio_2 == 8)
                        {
                            fichas += 20;

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t\t\t█ Ha ganado 20 fichas █");
                        }


                        //caso bufon
                        else if (aleatorio_1 == 9 || aleatorio_3 == 9 || aleatorio_2 == 9)
                        {
                            fichas -= 20;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\n\t\t\t\t\t\t\t█ Oh, no! te ha tocado el bufón, se te restarán 20 fichas █");
                        }
                        //caso trebol de 4 hojas
                        else if (aleatorio_1 == 10 || aleatorio_3 == 10 || aleatorio_2 == 10)
                        {
                            fichas += 10;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t\t\t█ Ha ganado 10 fichas █");
                        }

                        jackspot_spin = false;
                    }
                }
                else
                {
                    Console.Clear(); Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\nSaldo insuficiente, por favor compre más fichas\n");
                    goto inicio1;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(titulo + "\n\n");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@"
█▀▀ █ █▀▀ █░█ ▄▀█ █▀ ▀
█▀░ █ █▄▄ █▀█ █▀█ ▄█ ▄" + " \t" + fichas);

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\n ♣ Para girar el jackpot presiona 2 veces "); Console.ForegroundColor = ConsoleColor.Red; Console.Write(" Z \n");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\n ♣: Cada giro vale "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("10 fichas");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\t \t♣: 5 fichas valen ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("$90 monedas.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\t \t♣: El jugador solo puede comprar");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" 100 fichas");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\t \t♣: Para salir del juego presione 3 veces"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(" K");


                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\n\n█████████████████████████████████████████████████████████████████████████████████████\n");

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.Write($"{items_jackspot[aleatorio_1]}\n");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{items_jackspot[aleatorio_2]}\n");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{items_jackspot[aleatorio_3]}\n");

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("█████████████████████████████████████████████████████████████████████████████████");


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\n\n  Dinero ganado: ${contador_ganancias}");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\n  Billetera: ${billetera}");


                if ((tecla = Console.ReadKey(true)).Key == ConsoleKey.Z)
                {
                    Console.Clear();
                    goto spin_true;
                }
            }
            
        }

    }
}






