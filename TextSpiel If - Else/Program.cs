namespace TextSpiel_If___Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Szene 1
                Console.WriteLine("Stress! Du stehst morgens auf und bist spät dran für die Uni. " +
                    "Es würde knapp auf den Zug reichen, aber du hast auch ein Auto und das wäre nicht so stressig… " +
                    "Was machst du?");
                //A
                Console.WriteLine("A: Du sputest dich auf den Zug.");
                //B
                Console.WriteLine("B: Du nimmst gemütlich das Auto");
                Console.WriteLine("Wähle aus. Schreibe A oder B und bestätige mit Enter.");
                string eingabe1 = Console.ReadLine();
            if (eingabe1 == "A")
            {
                //Szene 2
                Console.WriteLine("...");
                Console.WriteLine("Du schaffst es zum Zug und fährst bis Basel. " +
                    "In Basel scheint die Sonne und du könntest anstatt in die Vorlesung auch in die Stadt gehen...");
                Console.WriteLine("Was machst du?");
                //A
                Console.WriteLine("A: Du gehst in die Vorlesung.");
                Console.WriteLine("B: Du gehst dir die Stadt anschauen.");
                Console.WriteLine("Wähle aus. Schreibe A oder B und bestätige mit Enter.");
                string eingabe2 = Console.ReadLine();
                if (eingabe2 == "A")
                {
                    //Szene 3
                    Console.WriteLine("...");
                    Console.WriteLine("Du sitzt in der Vorlesung und die geduldige Dozentin mit viel Zeit stellt eine Frage…");
                    Console.WriteLine("Wirst du:");
                    Console.WriteLine("A: Dich melden und Antwort geben.");
                    Console.WriteLine("B: Die Antwort jemand anderem¨überlassen.");
                    Console.WriteLine("Wähle aus. Schreibe A oder B und bestätige mit Enter.");
                    string eingabe3 = Console.ReadLine();
                    if (eingabe3 == "A") 
                    {
                        //Szene 4
                        Console.WriteLine("...");
                        Console.WriteLine("Du hast die Frage beantwortet und darfst in die Mittagspause! Jetzt hast du die Qual der Wahl eines Food-Standes");
                        Console.WriteLine("Beim Thai und Vietnamese stehen am wenigsten Leute an! Wo möchtest du essen?");
                        Console.WriteLine("A: Thai");
                        Console.WriteLine("B: Vientamesisch");
                        Console.WriteLine("Wähle aus. Schreibe A oder B und bestätige mit Enter.");
                        string eingabe4 = Console.ReadLine();
                        if (eingabe4 == "A")
                        {
                            Console.WriteLine("...");
                            Console.WriteLine("So leckeres thailändisches essen! Die Verkäuferin fragt ob du extra scharf möchtest?");

                        }
                        if (eingabe4 == "B")
                        {
                            Console.WriteLine("...");
                            Console.WriteLine("So leckeres vietnamisisches essen! Die Verkäuferin fragt ob du extra scharf möchtest?");

                        }

                        //Szene 5
                        
                        Console.WriteLine("Nimmst du Ihr angebot an?");
                        Console.WriteLine("A: Ja ich möchte gerne extra scharf!");
                        Console.WriteLine("B: Nein danke, heute kein extra scharf für mich.");
                        Console.WriteLine("Wähle aus. Schreibe A oder B und bestätige mit Enter.");
                        string eingabe5 = Console.ReadLine();
                        if (eingabe5 == "B")
                        {
                            //Szene 6
                            Console.WriteLine("...");
                            Console.WriteLine("Du nimmst kein extra scharf und das Mittagessen schmeckt super!");
                            Console.WriteLine("Als du zurück in die Klasse kommst ist kaum einer da...");
                            Console.WriteLine("Die Dozentin teilt dir mit dass fast alle wegen dem asian extra scharf an einem Kreislaufkollaps");
                            Console.WriteLine("verendet sind... Die Dozentin findet das etwas schade und schlägt vor den Nachmittag frei zu machen.");
                            Console.WriteLine("Nimmst du ihr angebot an?");
                            Console.WriteLine("A: Du nimmst ihr Angebot an und bekommst frei für den Nachmittag.");
                            Console.WriteLine("B: Du bestehst darauf den Unterricht weiterzuführen.");
                            Console.WriteLine("Wähle aus. Schreibe A oder B und bestätige mit Enter.");
                            string eingabe6 = Console.ReadLine();
                            if(eingabe6 == "B")
                            {
                                Console.WriteLine("...");
                                Console.WriteLine("Du möchtest nicht frei machen. In diesem Moment läuft Steffi (die kein Asian-Extra-Scharf bestellt hatte) in den Vorlesungssaal.");
                                Console.WriteLine("Sie ist von deiner Moativation so begeistert, dass sie dir das Master-Diplom direkt in die Finger drückt!");
                                Console.WriteLine(" Herzlichen Glückwunsch zu deinem Abschluss! ");
                            }
                            else
                            {
                                Console.WriteLine("...");
                                Console.WriteLine("Du akzeptierst das Angebot, bekommst frei und machst dich auf den Heimweg in Richtung Bahnhof.");
                                Console.WriteLine("Vor der Treppe die hinab zum Gleis führt wurde jedoch frisch gewischt und so rutschst du aus und stirbst beim Hinunterfallen.");
                                Console.WriteLine("Game Over!");
                            }

                        }
                        else
                        {
                            Console.WriteLine("...");
                            Console.WriteLine("Du wählst extra scharf. Jedoch ist es kein europäer extra scharf, sondern asian extra scharf!!");
                            Console.WriteLine("Da die Markhalle nur Reis-, Hafer- und Sojamilch führt gibt es nichts dass die Schärfe neutralisieren kann.");
                            Console.WriteLine("Du packst die Schärfe nicht und stirbst an einem Kreislaufkollaps...");
                            Console.WriteLine("Game Over! ");
                        }
                    }

                
                    else
                    {
                        //Szene 3B Du meldest dich nicht
                        Console.WriteLine("...");
                        Console.WriteLine("Du meldest dich nicht. Niemand meldet sich. Die Mittagspause kommt nie. ");
                        Console.WriteLine("Die Dozentin wartet so lange bis alle an Dehydrierung verenden.");
                        Console.WriteLine("Game Over");
                    }

                }
                else
                {
                    //Szene 2B Du gehst in die Stadt
                    Console.WriteLine("...");
                    Console.WriteLine("Du gehst in die Stadt. Als  du bei einer Tramstation vorbeiläufst stolperst du und fällst");
                    Console.WriteLine("vor ein vorbeifahrendes Tram und wirst überrollt.");
                    Console.WriteLine("Game Over");
                }
            }
            else
            {
                //Szene 2B Du nimmst das Auto
                Console.WriteLine("...");
                Console.WriteLine("Du nimmst das Auto stirbst auf halber strecke im Morgenverkehr bei einem Verkehrsunfall. ");
                Console.WriteLine("Game Over! Tschüss!");
            }   
            Console.ReadKey();
        }
    }
}