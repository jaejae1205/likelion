using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory2
{

    struct Item
    {
        public string Name;
        public int Count;

        public Item(string name, int count)
        {
            Name = name;
            Count = count;
        }
    }
    class Program
    {

        const int MAX_ITEMS = 10;

        static Item[] inventory = new Item[MAX_ITEMS];

        static void AddItem(string name, int count)
        {
            for(int i =0; i<MAX_ITEMS; i++)
            {
                if (inventory[i].Name == name)
                {
                    inventory[i].Count += count;
                    return;
                }

            }

            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (inventory[i].Name == null)
                {
                    inventory[i].Name = name;
                    inventory[i].Count = count;
                    return;
                }

            }
            Console.WriteLine("인벤토리가 가득 찼습니다.");

        }


        static void RemoveItem(string name, int count)
        {
            for(int i =0; i<MAX_ITEMS; i++)
            {
                if (inventory[i].Name == name)
                {
                    if (inventory[i].Count >= count)
                    {
                        inventory[i].Count -= count;
                        if (inventory[i].Count == 0)
                        {
                            inventory[i].Name = null;
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine("아이템 개수가 부족합니다!");
                        return;
                    }
                }


            }

            Console.WriteLine("아이템을 찾을 수 없습니다");


        }

        static void ShowInventory()
        {
            Console.WriteLine("현재 인벤토리 : ");
            bool isEmpty = true;

            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (inventory[i].Name != null)
                {
                    Console.WriteLine($"{inventory[i].Name} (x{inventory[i].Count})");
                    isEmpty = false;
                }
            }

            if (isEmpty)
            {
                Console.WriteLine("인벤토리가 비어 있습니다.");
            }
        }



        static void Main(string[] args)
        {
            //테스트 : 아이템 추가
            AddItem("포션", 5);
            AddItem("칼", 1);
            AddItem("포션", 3); //포션 개수 추가

            ShowInventory();

            //아이템 사용
            Console.WriteLine("포션 2개 사용");
            RemoveItem("포션", 2);
            ShowInventory();

            //테스트 : 없는 아이템 제거
            Console.WriteLine("방패 1개 제거 시도");
            RemoveItem("방패", 1);

            ShowInventory();


            //테스트: 모든 포션 제거
            Console.WriteLine("포션 6개 사용(초과 사용 테스트)");
            RemoveItem("포션", 6);
            ShowInventory();


        }
    }
}
