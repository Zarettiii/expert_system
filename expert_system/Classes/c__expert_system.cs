using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        private List<c__intermidiate_node> l__intermidiate_node; // Список промежуточных узлов



        /**
         * Конструктор
         * 
         * @param  string  s__path_to_esd  Путь до файла, содержащего схему
         */
        public c__expert_system(string s__path_to_esd)
        {
            l__intermidiate_node = new List<c__intermidiate_node>(); // Установить список промежуточных узлов
            l__terminal_node     = new List<c__terminal_node>();     // Установить список терминальных узлов


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
                // 
                //
                //
                //
                //
                //
                Array a__s__data = s__line.Split('/');


                //
                // Если такой элемент не существует в списке, то создать его
                //
                if ()
                {

                }
            }
        }



        /**
         * Вычислить значение гипотезы
         * 
         * @return  double  Значение гипотезы
         */
        public double calculate()
        {
            double d__hypothesis_value; // Значение гипотезы


            return d__hypothesis_value;
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
         * @param  byte           b__index_in         Индекс узла
         * @param  string         s__description_in   Описание узла
         * @param  List<ac__node> l__node__childs_in  Список дочерних узлов  
         */
        public c__intermidiate_node(byte b__index_in, string s__description_in, List<ac__node> l__node__childs_in)
        {
            b__index        = b__index_in;        // Установить индекс узла
            s__description  = s__description_in;  // Установить описание узла
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
        public void calculate_value()
        {
            d__value = 0; // Обнулить значение узла 


            //
            // Если в дочерних узлах нет положительных, то выйти
            //
            if (l__node__childs.Where(o => o.get_logical_value() == false).Count() == 0)
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
            }
            else
            {
                d__value = i__value_in; // Значение равно параметру
            }
        }
    }
}
