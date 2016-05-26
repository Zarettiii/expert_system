using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expert_system.Classes
{
    /**
     * Класс экспертной системы
     */
    class c__expert_system
    {
        //
        // ...
        // Поодключение к бд и сборка схемы хункционирования узлов
        // ...
        //
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
        protected byte   b__index;           // Индекс узла (его дентификатор)
        protected double d__weight;          // Вес узла

        

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
        }



        /**
         * Вычислить вес узла
         */
        public void calculate_weight()
        {
            // ...
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
    }
}
