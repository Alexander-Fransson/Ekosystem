using System;
using System.Collections.Generic;

namespace Ekosystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //skapar flockar

            BläckfiskShoal Shoalet = new BläckfiskShoal("Humboltbläckfiskshoalet");
            SpäckhuggarPod SpäckPoden = new SpäckhuggarPod("Späckhuggarpoden");
            Fiskstim Torskstimet = new Fiskstim("Torskstimmet");
            KaskelotPod KaskPoden = new KaskelotPod("Kaskelotpoden");

            //skapar instances av djur ochl ägger in djur i rätt flock

            VitHaj EnVitHaj = new VitHaj("Splash", "Vithaj", 14, 1, "gråish", "Vit under grå över", "Hona", 1000, 6.5);

            int minID = 2;
            int[] nums = new int[4];
            string[] namn = { "Torskar", "Kaskeloter", "Humboltbläckfiskar", "Späckhuggare" };

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Hur många " + namn[i] + " vill du ha?");
                int TheNum = int.Parse(Console.ReadLine());
                nums[i] = TheNum;
            }
            for (int i = 0; i < nums[0]; i++)
            {
                Torsk Torsken = new Torsk("Blub", "Torsk", 4, minID, "Grönish", "Grön med bruna prickar", "Hane", 2, 1);
                minID++;
                Torskstimet.Medlämmar.Add(Torsken);
            }
            for (int i = 0; i < nums[1]; i++)
            {
                Kaskelot Kaskeloten = new Kaskelot("KLICK! KLICK! KLICK! i 230 db", "Kaskelot", 45, minID, "Gråish", "Mörkgråblå med vita fläckar runt munnen", "Hane", 50000, 18);
                minID++;
                KaskPoden.Medlämmar.Add(Kaskeloten);
            }
            for (int i = 0; i < nums[2]; i++)
            {
                HumboltBläckfisk Sefalopoden = new HumboltBläckfisk(10, "plop plop", "Humboltbläckfisk", 1, minID, "Röd", "enfärgad", "Hona", 50, 2);
                minID++;
                Shoalet.Medlämmar.Add(Sefalopoden);
            }
            for (int i = 0; i < nums[3]; i++)
            {
                Späckhuggare Späckhuggaren = new Späckhuggare(2, "psssshht haaleow", "Späckhuggare", 11, minID, "svartvit", "Svart med vit undersida och vita fläckar bakom ögonen och bakom ryggfenan", "Hona", 3500, 6.5);
                minID++;
                SpäckPoden.Medlämmar.Add(Späckhuggaren);
            }


            // Game of Life

            int day = 0;

            Console.WriteLine("\nstartar game of life\n---------------------------------------------------------------------------------------------------\n");

            while (SpäckPoden.Medlämmar.Count > 0 && Shoalet.Medlämmar.Count > 0 && KaskPoden.Medlämmar.Count > 0 && Torskstimet.Medlämmar.Count > 0 && minID < 30)
            {
                day++;

                Random rnd = new Random();

                int vilkenclass = rnd.Next(1, 10);

                switch (vilkenclass)
                {
                    case 1:
                        //shoalet

                        int gärning = rnd.Next(1, 3);

                        if (gärning == 1)
                        {
                            Shoalet.BlinkaTillsammans();
                        }
                        else
                        {
                            Shoalet.Resatillsammans();
                        }

                        break;
                    case 2:
                        //torskstimmet

                        int torskgärning = rnd.Next(1, 3);

                        if (torskgärning == 1)
                        {
                            Torskstimet.Synkarörelser();
                        }
                        else
                        {
                            Torskstimet.Resatillsammans();
                        }

                        break;
                    case 3:
                        //Kaskpoden

                        int kaskgärning = rnd.Next(1, 3);

                        if (kaskgärning == 1)
                        {
                            KaskPoden.Margarite();
                        }
                        else
                        {
                            KaskPoden.Resatillsammans();
                        }
                        break;
                    case 4:
                        //späckpoden

                        int späckgärning = rnd.Next(1, 3);

                        if (späckgärning == 1)
                        {
                            Torskstimet.Synkarörelser();
                        }
                        else
                        {
                            Torskstimet.Resatillsammans();
                        }
                        break;
                    case 5:
                        //späckhuggare

                        int enSpäckgärning = rnd.Next(1, 10);
                        int ettDjur = rnd.Next(0, SpäckPoden.Medlämmar.Count);

                        switch (enSpäckgärning)
                        {
                            case 1:       
                                minID++;
                                SpäckPoden.Medlämmar[ettDjur].FödaSpäckhuggare(SpäckPoden.Medlämmar, minID);

                                break;
                            case 2:

                                SpäckPoden.Medlämmar[ettDjur].Låta();

                                break;
                            case 3:

                                SpäckPoden.Medlämmar[ettDjur].Sova();

                                break;
                            case 4:

                                SpäckPoden.Medlämmar[ettDjur].Uppfostra();

                                break;
                            case 5:

                                SpäckPoden.Medlämmar[ettDjur].mobba(EnVitHaj);

                                break;
                            case 6:

                                SpäckPoden.Medlämmar[ettDjur].Komunicera();

                                break;
                            case 7:

                                SpäckPoden.Medlämmar[ettDjur].JagaKaskelot(KaskPoden);

                                break;
                            case 8:

                                SpäckPoden.Medlämmar[ettDjur].JagaFisk(Torskstimet);

                                break;
                            default:

                                SpäckPoden.Medlämmar[ettDjur].JagaBläckfisk(Shoalet);

                                break;
                        }
                        break;
                    case 6:
                        //kaskelot

                        int enKaskGärning = rnd.Next(1, 8);
                        int enKaskelot = rnd.Next(0, KaskPoden.Medlämmar.Count);

                        switch (enKaskGärning)
                        {
                            case 1:
                                minID++;
                                KaskPoden.Medlämmar[enKaskelot].FödaKaskeloter(KaskPoden.Medlämmar, minID);
                                break;
                            case 2:
                                KaskPoden.Medlämmar[enKaskelot].AndasLuft();
                                break;
                            case 3:
                                KaskPoden.Medlämmar[enKaskelot].BajsaParfym();
                                break;
                            case 4:
                                KaskPoden.Medlämmar[enKaskelot].JagaBläckfisk(Shoalet);
                                break;
                            case 5:
                                KaskPoden.Medlämmar[enKaskelot].Klicka();
                                break;
                            default:
                                KaskPoden.Medlämmar[enKaskelot].Komunicera();
                                break;
                        }
                        break;
                    case 7:
                        //torsk

                        int enTorskGärning = rnd.Next(1, 8);
                        int enTorsk = rnd.Next(0, Torskstimet.Medlämmar.Count);

                        switch (enTorskGärning)
                        {
                            case 1:
                                minID++;
                                Torskstimet.Medlämmar[enTorsk].LäggaTorskÄgg(Torskstimet.Medlämmar, minID);
                                break;
                            case 2:
                                Torskstimet.Medlämmar[enTorsk].Låta();
                                break;
                            case 3:
                                Torskstimet.Medlämmar[enTorsk].Plaska();
                                break;
                            case 4:
                                Torskstimet.Medlämmar[enTorsk].Sidolinjeorgan();
                                break;
                            case 5:
                                Torskstimet.Medlämmar[enTorsk].Sova();
                                break;
                            case 6:
                                Torskstimet.Medlämmar[enTorsk].Äta();
                                break;
                            default:
                                Torskstimet.Medlämmar[enTorsk].Simma();
                                break;
                        }

                        break;
                    case 8:
                        //humboltbläckfisk

                        int enBläckGärning = rnd.Next(1, 10);
                        int enBläckfisk = rnd.Next(0, Shoalet.Medlämmar.Count);

                        switch (enBläckGärning)
                        {
                            case 1:
                                Shoalet.Medlämmar[enBläckfisk].AndasVatten();
                                break;
                            case 2:
                                Shoalet.Medlämmar[enBläckfisk].JagaFisk(Torskstimet);
                                break;
                            case 3:
                                Shoalet.Medlämmar[enBläckfisk].Kanibalism(Shoalet);
                                break;
                            case 4:
                                Shoalet.Medlämmar[enBläckfisk].Låta();
                                break;
                            case 5:
                                Shoalet.Medlämmar[enBläckfisk].Simma();
                                break;
                            case 6:
                                Shoalet.Medlämmar[enBläckfisk].Sova();
                                break;
                            case 7:
                                Shoalet.Medlämmar[enBläckfisk].Vattenjätt();
                                break;
                            case 8:
                                Shoalet.Medlämmar[enBläckfisk].ÄndraFärg();
                                break;
                            default:
                                minID++;
                                Shoalet.Medlämmar[enBläckfisk].LäggaHumboltÄgg(Shoalet.Medlämmar, minID);
                                break;
                        }
                        break;
                    default:
                        //vithaj
                        int enhajGärning = rnd.Next(1, 10);

                        switch (enhajGärning)
                        {
                            case 1:
                                EnVitHaj.LuktaBlod();
                                break;
                            case 2:
                                EnVitHaj.Låta();
                                break;
                            case 3:
                                EnVitHaj.Elektroreception();
                                break;
                            case 4:
                                EnVitHaj.Sidolinjeorgan();
                                break;
                            case 5:
                                EnVitHaj.Sova();
                                break;
                            case 6:
                                EnVitHaj.AndasVatten();
                                break;
                            case 7:
                                EnVitHaj.JagaBläckfisk(Shoalet);
                                break;
                            case 8:
                                EnVitHaj.JagaFisk(Torskstimet);
                                break;
                            case 9:
                                EnVitHaj.ÄtaNyföddaHajungar();
                                break;
                            default:
                                EnVitHaj.Simma();
                                break;
                        }
                        break;
                }
            }

            Console.WriteLine("\n---------------------------------------------------------------------------------------------------\n\nEkosystemet Kolapsade\nDet varade " + day+" dagar");
        }
    }
}

