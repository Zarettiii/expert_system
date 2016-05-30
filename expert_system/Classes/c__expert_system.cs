using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace expert_system.Classes
{
    /**
     * Класс экспертной системы
     */
    class c__expert_system
    {
        public List<c__terminal_node> l__terminal_node; // Список терминальных узлов

        public List<c__intermidiate_node> l__intermidiate_node; // Список промежуточных узлов

        private string s__path_to_esd; // Путь до файла схемы



        /**
         * Конструктор
         * 
         * @param  string  s__path_to_esd  Путь до файла, содержащего схему
         */
        public c__expert_system(string s__path_to_esd_in)
        {
            l__intermidiate_node = new List<c__intermidiate_node>(); // Установить список промежуточных узлов
            l__terminal_node     = new List<c__terminal_node>();     // Установить список терминальных узлов

            s__path_to_esd = s__path_to_esd_in; // Установить путь до файла схемы


            //
            // Проверить существование файла схемы
            //
            if (File.Exists(s__path_to_esd) == false)
            {
                throw new FileNotFoundException(); // Сгенерировать исключение
            }


            string s__line; // Строка для работы с файлом

            StreamReader sr__reader = new StreamReader(s__path_to_esd); // Открыть ридер файла схемы

            //
            // Построчно читать файл и создавать элементы
            //
            while ((s__line = sr__reader.ReadLine()) != null)
            {
                //
                // Массив с данными из строки
                // 
                // [0] - "C" (промежуточный узел)   "Е" (терминальный узел)
                // [1] - Индекс узла
                // [2] - Описание узла
                // [3] - Индекс промежуточного родительского узла
                // [4] - Вес узла                
                // [5] - Обратимость узла (1 - обратим, 0 - необратим)
                //
                string[] a__s__data = s__line.Split('/');


                //
                // Определить какой узел будет создан
                //
                if (a__s__data[0] == "C") // Создать промежуточный узел
                {
                    bool b__reversability; // Обратимость узла

                    //
                    // Установить значение обратимости узла
                    //
                    if (a__s__data[5] == "1")
                    {
                        b__reversability = true; // Установить обратимость
                    }
                    else
                    {
                        b__reversability = false; // Установить обратимость
                    }



                    create_intermidiate_node(
                                                byte.Parse(a__s__data[1]),
                                                a__s__data[2],
                                                double.Parse(a__s__data[4]),
                                                b__reversability
                                            );
                }
                else // Создеать терминальный узел
                {                    
                    create_terminal_node(
                                            byte.Parse(a__s__data[1]),
                                            a__s__data[2],
                                            double.Parse(a__s__data[4])
                                        );
                }
            }

            sr__reader.Close(); // Закрыть ридер файла                    


            make_relations(); // Построить связи между узлами
        }



        /**
         * Создать терминальный узел
         * 
         * @param  byte    b__index_in        Индекс узла
         * @param  string  s__description_in  Описание узла
         * @param  double  d__weight_in       Вес узла
         */
        private void create_terminal_node(byte b__index_in, string s__description_in, double d__weight_in)
        {
            //
            // Создать новый узел
            //
            c__terminal_node tn__new_node = new c__terminal_node(
                                                                    b__index_in, 
                                                                    s__description_in, 
                                                                    d__weight_in
                                                                );


            l__terminal_node.Add(tn__new_node); // Добавить узел в список
        }



        /**
         * Создать промежуточный узел
         * 
         * @param  byte    b__index_in            Индекс узла
         * @param  string  s__description_in      Описание узла
         * @param  double  d__weight_in           Вес узла
         * @param  bool    boo__reversability_in  Обратимость узла
         */
        private void create_intermidiate_node(
                                                byte b__index_in, 
                                                string s__description_in, 
                                                double d__weight_in, 
                                                bool boo__reversability_in
                                             )
        {
            //
            // Создать новый узел
            //
            c__intermidiate_node in__new_node = new c__intermidiate_node(
                                                                            b__index_in, 
                                                                            s__description_in, 
                                                                            d__weight_in,
                                                                            boo__reversability_in                                                                          
                                                                        );


            l__intermidiate_node.Add(in__new_node); // Добавить узел в список
        }



        /**
         * Построить связи между узлами
         */
        private void make_relations()
        {
            string s__line; // Строка для работы с файлом


            //
            // Создать связи для каждого промежуточного узла
            //
            foreach (c__intermidiate_node in__item in l__intermidiate_node)
            {
                List<ac__node> l__node__childs = new List<ac__node>(); // Список ссылок на узлы
                

                StreamReader sr__reader = new StreamReader(s__path_to_esd); // Открыть ридер файла схемы

                //
                // Построчно читать файл
                //
                while ((s__line = sr__reader.ReadLine()) != null)
                {
                    //
                    // Массив с данными из строки
                    // 
                    // [0] - "C" (промежуточный узел)   "Е" (терминальный узел)
                    // [1] - Индекс узла
                    // [2] - Описание узла
                    // [3] - Индекс промежуточного родительского узла
                    // [4] - Вес узла                
                    // [5] - Обратимость узла (1 - обратим, 0 - необратим)
                    //
                    string[] a__s__data = s__line.Split('/');


                    //
                    // Если узел не имеет связи, то перейти к следующей итерации
                    //
                    if (a__s__data[3] == "")
                    {
                        continue; // Переход к следующей итерации
                    }

                    
                    //
                    // Если есть связь, то добавить в список связей
                    //
                    if (byte.Parse(a__s__data[3]) == in__item.get_index())
                    {
                        //
                        // Определить тип узла для добавления
                        //
                        if (a__s__data[0] == "C") // Промежуточный узел
                        {
                            //
                            // Добавить в список соответвстующий узел
                            //
                            l__node__childs.Add(l__intermidiate_node.Where(o => o.get_index() == byte.Parse(a__s__data[1])).First());
                        }
                        else // Терминальный узел
                        {
                            //
                            // Добавить в список соответвстующий узел
                            //
                            l__node__childs.Add(l__terminal_node.Where(o => o.get_index() == byte.Parse(a__s__data[1])).First());
                        }
                    }


                    in__item.set_childs(l__node__childs);
                }

                sr__reader.Close(); // Закрыть ридер файла
            }            
        }



        /**
         * Вычислить значение гипотезы
         * 
         * @return  double  Значение гипотезы
         */
        public double calculate()
        {
            //
            // Отсортировать промежуточные узлы по убыванию ключа
            //
            l__intermidiate_node = l__intermidiate_node.OrderByDescending(o => o.get_index()).ToList();


            //
            // Вычислить значение для каждого узла
            //
            foreach (c__intermidiate_node in__item in l__intermidiate_node)
            {
                in__item.calculate_logical_value(); // Вычислить значение узла
            }

            
            //
            // Вернуть значение гипотезы
            //
            return l__intermidiate_node.Where(o => o.get_index() == 0).First().get_value(); 
        } 
    }




    /**
     * Абстрактный класс узла 
     * 
     * Описывает основные поля для узла и методы для работы с ними
     */
    abstract class ac__node
    {
        protected bool   boo__logical_value; // Логическое значение узла (да, нет)
        protected string s__description;     // Описание узла
        protected byte   b__index;           // Индекс узла (его идентификатор)
        protected double d__weight;          // Вес узла
        protected double d__value;           // Значение узла

        

        /**
         * Получить логическое значение узла
         * 
         * @return  bool  Логическое значение узла
         */
        public bool get_logical_value()
        {
            return boo__logical_value; // Вернуть логическое значение
        }



        /**
         * Установить логическое значение узла
         * 
         * @param  bool  boo__logical_value_in  Логическое значение
         */
        public void set_logical_value(bool boo__logical_value_in)
        {
            boo__logical_value = boo__logical_value_in; // Установить логическое значение
        }



        /**
         * Получить описание узла
         * 
         * @return  string  Описание узла
         */
        public string get_description()
        {
            return s__description; // Вернуть описание
        }



        /**
         * Получить индекс узла 
         * 
         * @return  byte  Индекс узла
         */
        public byte get_index()
        {
            return b__index; // Вернуть индекс узла
        }



        /**
         * Получить значение узла 
         * 
         * @return  double  Значение узла
         */
        public double get_value()
        {
            return d__value; // Вернуть значение узла
        }



        /**
         * Получить вес узла 
         * 
         * @return  double  Вес узла
         */
        public double get_weight()
        {
            return d__weight; // Вернуть вес узла
        }
    }




    /**
     * Класс промежуточного узла
     */
    class c__intermidiate_node:ac__node
    {
        //
        // Обратимость узла
        // true  - обратим (если дочерние узлы негативны, то и этот узел негативен) 
        // false - необратим (хотя бы один дочерний узел должен быть положителен для положительности этого узла)        
        //
        private bool boo__reversibility;

        private List<ac__node> l__node__childs; // Список дочерних узлов             



        /**
         * Конструктор
         * 
         * @param  byte            b__index_in            Индекс узла
         * @param  string          s__description_in      Описание узла
         * @param  double          d__weight_in           Вес узла 
         * @param  bool            boo__reversability_in  Обратимость узла          
         */
        public c__intermidiate_node(
                                        byte b__index_in, 
                                        string s__description_in, 
                                        double d__weight_in, 
                                        bool boo__reversability_in
                                   )
        {
            b__index           = b__index_in;           // Установить индекс узла
            s__description     = s__description_in;     // Установить описание узла
            l__node__childs    = new List<ac__node>();  // Установить список дочерних узлов
            d__weight          = d__weight_in;          // Установить вес узла
            boo__reversibility = boo__reversability_in; // Установить обратимость узла  
        }



        /**
         * Установить список дочерних узлов
         * 
         * @param  List<ac__node>  l__node__childs_in  Лист дочерних узлов
         */
        public void set_childs(List<ac__node> l__node__childs_in)
        {
            l__node__childs = l__node__childs_in; // Установить список дочерних узлов
        }



        /**
         * Вычислить и установить логическое значение для узла 
         */
        public void calculate_logical_value()
        {
            //
            // Выбрать логику подсчета значения исходя из параметра обратимости 
            //
            if (boo__reversibility) // Если узел обратим 
            {
                boo__logical_value = true; // Для начала, принять узел как положительный


                //
                // Перебрать логические значения дочерних узлов 
                //
                foreach (ac__node node__item in l__node__childs)
                {
                    //
                    // Если хоть один дочерний узел негативен, то и этот узел негативен
                    //
                    if (node__item.get_logical_value() == false)
                    {
                        boo__logical_value = false; // Установить негативность узла

                        break; // Условие негативности выполнено, можно выйти из цикла
                    }
                }
            }
            else //Если узел необратим
            {
                boo__logical_value = false; // Для начала, принять узел как негативный


                //
                // Перебрать логические значения дочерних узлов 
                //
                foreach (ac__node node__item in l__node__childs)
                {
                    //
                    // Если хоть один дочерний узел положителен, то и этот узел положителен
                    //
                    if (node__item.get_logical_value() == true)
                    {
                        boo__logical_value = true; // Установить положительность узла

                        break; // Условие положительности выполнено, можно выйти из цикла
                    }
                }
            }


            calculate_value(); // Вычислить значение для узла
        }



        /**
         * Вычислить вес узла
         */
        private void calculate_value()
        {
            d__value = 0; // Обнулить значение узла 


            //
            // Если в дочерних узлах нет положительных, то выйти
            //
            if (l__node__childs.Where(o => o.get_logical_value() == false).Count() != 0)
            {
                return; // Выйти из функции
            }


            d__value += d__weight; // Добавить к значению вес узла


            //
            // Перебрать дочерние узлы с посчитать значение ротиельского
            //
            foreach (ac__node node__item in l__node__childs)
            {
                //
                // Если дочерний узел положителен, то прибавить его значение к родителю
                //
                if (node__item.get_logical_value() == true)
                {
                    d__value += node__item.get_value(); // Прибавить значение 
                }
            }            
        }



        /**
         * Получить значение обратимости
         * 
         * @return  bool  Обратимость
         */
        public bool get_reversibility()
        {
            return boo__reversibility; // Вернуть значение обратимости
        }
    }




    /**
     * Класс терминального узла
     */
    class c__terminal_node:ac__node
    {
        /**
         * Конструктор
         * 
         * @param  byte    b__index_in        Индекс узла
         * @param  string  s__description_in  Описание узла
         * @param  double  d__weight_in       Вес узла 
         */
        public c__terminal_node(byte b__index_in, string s__description_in, double d__weight_in)
        {
            b__index       = b__index_in;       // Установить индекс узла
            s__description = s__description_in; // Установить описание узла
            d__weight      = d__weight_in;      // Установить вес узла
        }



        /**
         * Установить входное значение
         * 
         * @param  int  i__value_in  Входное значение
         */
        public void set_value(int i__value_in)
        {
            //
            // Если входное значение равно нулю, то узел негативен
            //
            if (i__value_in == 0)
            {
                d__value = 0; // Значение узла равно 0

                boo__logical_value = false;
            }
            else
            {
                d__value = i__value_in; // Значение равно параметру

                boo__logical_value = true;
            }
        }
    }
}
