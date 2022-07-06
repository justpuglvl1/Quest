 
namespace Quest
{

    class Program
    {

        static int roomNumber = 1;
        static bool hasKey = false;
        static bool hasModule = false;


        static void Main(string[] args)
        {
            Introduction();

            while (true)
            {
                if      (roomNumber == 1) ActionStarship();
                else if (roomNumber == 2) ActionTemple();
                else if (roomNumber == 3) ActionLivingRoom();
                else if (roomNumber == 4) ActionDangerRoom();
                else if (roomNumber == 5) ActionQuestRoom();
                else if (roomNumber == 6) ActionOtherShip();
            }

        }

         
        static void ActionStarship()
        {
            Console.Clear();
            Console.WriteLine("Ты находишься внутри своего С- 6 Starlight");
            Console.WriteLine("Тебе нужно топливо и очевидно, что искать его нужно не тут");
            Console.WriteLine("Доступные действия:");
            Console.WriteLine("1. Выйти из корабля");
            int option;
            if (hasModule)
            {
                Console.WriteLine("2. Свалить с планеты");               
                option = GetIntInRange(2);
            }
            else option = GetIntInRange(1);

            if(option == 1)
            {
                Console.WriteLine("Ты выходишь из корабля");
                Console.ReadKey();
                roomNumber = 2;
            }
            else if (option == 2)
            {
                Conclusion();
            }

        }

        static void ActionTemple()
        {
            Console.Clear();
            Console.WriteLine("Ты находишься в просторном каменном зале");
            Console.WriteLine("(Довольно странно, что упал именно внутрь какого-то здания)");
            Console.WriteLine("Перед тобой дверь из за которой выглядывает свет");
            Console.WriteLine("Справа от нее другая дверь, выглядит так, будто ей давно никто не пользовался");
            Console.WriteLine("Доступные действия");
            Console.WriteLine("1. Вернуться на корабль");
            Console.WriteLine("2. Зайти в дверь со светом внутри");
            Console.WriteLine("3. Подойти к двери справа");
            int option = GetIntInRange(3);

            if( option == 1)
            {
                Console.WriteLine("Вы вернулись на корабль");
                Console.ReadKey();
                roomNumber = 1;
            }
            else if(option == 2)
            {
                Console.WriteLine("Ты идешь к двери со светом и проходишь во внутрь");
                Console.ReadKey();
                roomNumber = 3;
            }
            else
            {
                OpenOldDoor();
            }

        }

        static void OpenOldDoor()
        {
            Console.WriteLine("Вы подходите к старой двери");
            if (hasKey)
            {
                Console.WriteLine("Вы проверяете подходит ли ключ к замку и... О чудо, он подходит");
                Console.WriteLine("Открыв со скрипом дверь и проходите дальше");
                Console.ReadKey();
                roomNumber = 4;
            }
            else
            {
                Console.WriteLine("Подойдя к двери и пнув ее пару раз, вы понимаете, что открываться онa не собирается");
                Console.ReadKey();
            }
        }


        static void ActionLivingRoom()
        {
            Console.Clear();
            Console.WriteLine("Открыв дверь ты попал в маленькое помещение, будто чулан");
            Console.WriteLine("Хотя здесь точно недавно кто-то был, ведь горит каменный камин");
            Console.WriteLine("Здесь будто недавно кто то был...");
            Console.WriteLine("* а раз кто-то здесь был, то здесь наверняка есть что-то интересное");
            Console.WriteLine("Доступные действия: ");
            Console.WriteLine("1. Вернуться обратно в зал");
            int option;
            if (!hasKey)
            {
                Console.WriteLine("2. Обыскать помещение");
                option = GetIntInRange(2);
            }
            else
            {
                option = GetIntInRange(1);
            }

            if (option == 1)
            {
                Console.WriteLine("Вы развернулись и пошли обратно в зал");
                Console.ReadKey();
                roomNumber = 2;

            }
            else
            {
                Console.WriteLine("Обыскав комнату вы нашли ключ и засунули себе в карман");
                Console.ReadKey();
                hasKey = true;
            }

        }

        static void ActionDangerRoom()
        {
            Console.Clear();
            Console.WriteLine("Как только ты вошел в комнату, ты сразу почувствовал себя неуютно");
            Console.WriteLine("Отсюда хочется поскорее сбежать, все твое нутро тебе говорит об этом");
            Console.WriteLine("В этом помещении очень темно, однако ты будто бы видишь вдалеке слева луч света");
            Console.WriteLine("Доступные действия:");
            Console.WriteLine("1. Вернуться обратно в каменный зал");
            Console.WriteLine("2. Добежать до света");
            Console.WriteLine("3. Обследовать темные углы этого помещения");
            int option = GetIntInRange(3);

            if(option == 1)
            {
                Console.WriteLine("Возвращаемся обратно...");
                roomNumber = 2;
                Console.ReadKey();
            }
            else if(option == 2)
            {
                Console.WriteLine("Подойдя ближе к свету, ты понял, что этот свет исходит из двери");
                Console.WriteLine("В этом темном зале тебе было не по себе, недолго думая ты заходишь во внутрь");
                roomNumber = 5;
                Console.ReadKey();
            }
            else
            {
                Death();
            }


        }


        static void Death()
        {
            Console.Clear();
            Console.WriteLine("Дойдя до темных частей зала тебя охватывает дрожь по всему телу");
            Console.ReadKey();
            Console.WriteLine("В этой темной бездне точно что-то сокрыто и оно будто движется к тебе");
            Console.ReadKey();
            Console.WriteLine("Ты пытаешься бежать обратно, но страх так силен, что ты едва сумел развернуться");
            Console.ReadKey();
            Console.WriteLine("Хотя это уже не имеет значения, что-то быстро летит к тебе сзади");
            Console.WriteLine("Ты понимаешь, что это конец...");
            Console.ReadKey();
            Console.WriteLine("Надо было слушать свою интуицию...");
            Console.ReadKey();
            Environment.Exit(0);

        }


        static void ActionQuestRoom()
        {
            Console.Clear();
            Console.WriteLine("А в этом зале довольно уютно");
            Console.WriteLine("Зал небольшой, спереди находится какая то дверь со странным знаком");
            Console.WriteLine("На стенах что-то написано краской серебренного цвета");
            Console.WriteLine("Доступные действия:");
            Console.WriteLine("1. Вернуться в страшный зал");
            Console.WriteLine("2. Подойти к двери с замком");
            int option = GetIntInRange(2);

            if(option == 1)
            {
                Console.WriteLine("Возвращаемся обратно...");
                roomNumber = 4;
                Console.ReadKey();

            }
            else
            {
                CompleteQuest();
            }
        }


        static void CompleteQuest()
        {
            Console.Clear();
            Console.WriteLine("Подойдя к двери ты обнаружил, что на ней висит кодовый замок");
            Console.WriteLine("Чтобы открыть его, нужно ввести слово из 9 букв, хм... что это за слово...");
            Console.WriteLine("Недолго подумав, ты решил разглядеть надписи на стенах, на них написано:");
            Console.WriteLine("=========================================================================");
            Console.WriteLine("Есть я у мужа, у зверя, у мёртвого камня, у облака.");
            Console.WriteLine("В душу не лезу, ловлю изменения облика.");
            Console.WriteLine("Дева, взгляну на меня, приосанится. ");
            Console.WriteLine("Старец нахмурится, дитятко расхулиганится.");
            Console.WriteLine("Кто я? (*последняя строка написана прямо на дверью)");

            Console.WriteLine("Теперь нужно ввести слово: ");
            string answer = Console.ReadLine();

            while(answer.ToLower() != "отражение")
            {
                Console.WriteLine("Замок пропищал, но не открылся, попробуй еще раз: ");
                answer = Console.ReadLine();
            }

            Console.WriteLine("Комната открылась, ты проходишь дальше");
            roomNumber = 6;
            Console.ReadKey();

        }


        static void ActionOtherShip()
        {
            Console.Clear();
            Console.WriteLine("Зайдя в следующую комнату ты увидел не большое помещение");
            Console.WriteLine("В нем валялись куски от твоего корабля");
            Console.WriteLine("Доступные действия: ");
            Console.WriteLine("1. Вернуться обратно");
            Console.WriteLine("2. Обыскать обломки");

            int option = GetIntInRange(2);
            if(option == 1)
            {
                Console.WriteLine("Возвращаемся обратно...");
                roomNumber = 5;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ты долго копался в обломках");
                Console.ReadKey();
                Console.WriteLine("Исцарапал все свои руки, избил себя до полу смерти");
                Console.ReadKey();
                Console.WriteLine("И о чудо... ты увидел работающий модуль");
                Console.ReadKey();
                Console.WriteLine("===========================================");
                Console.WriteLine("*ты засуну его за шиворот");
                Console.ReadKey();
                hasModule = true;
            }

        }


        static void Introduction()
        {
            Console.WriteLine("Ты смутно помнишь где ты...Даже кто ты...");
            Console.ReadLine();
            Console.WriteLine("Тело сдавлено, однако твой мозг уже подает сигналы жизни...");
            Console.WriteLine("Он говорить, ремень...");
            Console.ReadLine();
            Console.WriteLine("Давит на все тело, а именно грудная клетка, машинально ты бьешь куда ниже бедра...");
            Console.WriteLine("Щелчок и ты летишь куда то вниз...");
            Console.ReadLine();
            Console.WriteLine("Небольшой удар об пол твоего корабля, да после такой встряски твой мозг точно начал работать");
            Console.WriteLine("Со скоростью молнии ты вспоминаешь последние 24 часа, хотя тебе и не хочется вспоминать...");
            Console.ReadLine();
            Console.WriteLine("Вы в составе 3-ей эскадры были отправлены на патрулирование близ Кеплана-7");
            Console.WriteLine("Дежурство как дежурство, последние 2 года все дни были практически одинаковые");
            Console.WriteLine("Разве что менялось это виды космоса... хотя что интересного в нем можно увидеть");
            Console.ReadLine();
            Console.WriteLine("Ваша эскадра стояла на удалении пару десятков тысяч километров над поверхностью планеты");
            Console.WriteLine("Внезапно ты заметил, что зеленый Кеплан стал больше и он увеличивается...");
            Console.WriteLine("Нет, он стоит на месте, это просто вашу эскадру тянет к нему, будто сильным магнитом");
            Console.ReadLine();
            Console.WriteLine("Последние 10 минут, что ты помнишь - это то как тщетно пытался выбраться из этого магнитного крюка");
            Console.WriteLine("Однако... теперь ты здесь... и судя по всему приземлился ты не очень...");
            Console.WriteLine("Энергощит защитил корабль от критических повреждений, зато теперь топливо практически на нуле");
            Console.WriteLine("Разбираться с тем, что произошло будем потом, сейчас надо найти топливо");
            Console.WriteLine("В любом случае нужно хотя бы покинуть корабль");
            Console.ReadLine();

        }


        static void Conclusion()
        {
            Console.WriteLine("Ты засунул этот ебанный моудль в его ебанное место");
            Console.ReadKey();
            Console.WriteLine("Дополнительно уебав его ногой и наорав на него, ты сел на место пилота");
            Console.ReadKey();
            Console.WriteLine("Вдруг ты понял, что никого не встретил из свой команды");
            Console.ReadKey();
            Console.WriteLine("Д-ополнительно оглянувший, ты решил, что остался один");
            Console.ReadKey();
            Environment.Exit(0);
        }


        static int GetIntInRange(int optionsNumber)
        {
            string input = Console.ReadLine();
            int number = -1;
            bool isConverted = int.TryParse(input, out number);
            bool isInRage = number >= 1 && number <= optionsNumber ;

            while (!isConverted || !isInRage)
            {
                Console.WriteLine("Ты долбоеб");
                input = Console.ReadLine();
                isConverted = int.TryParse(input, out number);
                isInRage = number >= 1 && number <= optionsNumber;
            }

            return number;
        }

    }




}