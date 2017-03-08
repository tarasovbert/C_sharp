using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    public class Map
    {
        string[] Keys = new string[0];
        double[] Values = new double[0];

        // Сводка: Инициализирует новый пустой экземпляр класса 
        public Map() { }

        // Сводка: Возвращает число пар "ключ-значение", содержащихся в словаре 
        public int Count
        {
            get { return Keys.Length; }
        }

        // Сводка: Получает массив, содержащий ключи в словаре 
        public string[] GetKeys
        {
            get { return Keys; }
        }

        //Сводка: Получает массив, содержащий значения в словаре 
        public double[] GetValues
        {
            get { return Values; }
        }

        // Сводка:  Возвращает или задает значение, связанное с указанным ключом.
        // Параметры:
        //   key:
        //     Ключ, значение которого требуется получить или задать.
        // Возвращает:
        //     Значение, связанное с указанным ключом. 
        //    Если указанный ключ не найден, операция 
        //    генерирует исключение KeyNotExistException,
        public double this[string key]
        {
            get
            {
                int i;
                for (i = 0; i < Keys.Length; i++)
                    if (Keys[i] == key) break;
                if (i == Keys.Length - 1)
                    throw new KeyDoesNotExistException("Such key doesn't exist in the map");
                return Values[i];
            }
            set
            {
                int i;
                for (i = 0; i < Keys.Length; i++)
                    if (Keys[i] == key) break;
                if (i == Keys.Length - 1)
                    throw new KeyDoesNotExistException("Such key doesn't exist in the map");
                Values[i] = value;
            }
        }

        // Сводка:
        //     Добавляет указанные ключ и значение в словарь.
        // Параметры: key - Ключ добавляемого элемента.
        //   value - Добавляемое значение элемента. 
        // Исключения - System.ArgumentException: Элемент с таким ключом уже существует в словаре
        public void Add(string key, double value)
        {
            for (int i = 0; i < Keys.Length; i++)
            {
                if (Keys[i] == key)
                    throw new ArgumentException("Such key already exists in the map");
                Array.Resize(ref Keys, Keys.Length + 1);
                Keys[Keys.Length - 1] = key;
                Array.Resize(ref Values, Values.Length + 1);
                Values[Values.Length - 1] = value;
            }
        }

        // Сводка:
        //     Удаляет все ключи и значения из словаря 
        public void Clear()
        {
            Array.Resize(ref Keys, 0);
            Array.Resize(ref Values, 0);
        }

        // Сводка:
        //     Определяет, содержится ли указанный ключ в словаре
        // Параметры:
        //   key:
        //     Ключ, который требуется найти в
        // Возвращает:
        //     true, если словарь содержит элемент  с указанным ключом, 
        //     в противном случае — false.
        public bool ContainsKey(string key)
        {
            for (int i = 0; i < Keys.Length; i++)
                if (Keys[i] == key)
                    return true;
            return false;
        }

        // Сводка:
        //     Определяет, содержит ли словарь указанное значение.
        // Параметры:
        //   value:
        //     Значение, которое требуется найти в словаре 
        // Возвращает:
        //     Значение true, если элемент с указанным значением, 
        //     в противном случае — значение false.
        public bool ContainsValue(double value)
        {
            for (int i = 0; i < Values.Length; i++)
                if (Values[i] == value)
                    return true;
            return false;
        }

        // Сводка:
        // Удаляет значение с указанным ключом из словаря
        // Параметры: key - Ключ элемента, который необходимо удалить.
        // Возвращает: true, если элемент успешно найден и удален, в противном случае — false. 
        // Этот метод возвращает значение false, если ключ key не найден в словаре
        public bool Remove(string key)
        {
            for (int i = 0; i < Keys.Length; i++)
                if (Keys[i] == key)
                {
                    string[] CopyKeys = new string[Keys.Length];
                    double[] CopyValues = new double[Values.Length];
                    Array.Copy(Keys, CopyKeys, Keys.Length);
                    Array.Copy(Values, CopyValues, Values.Length);
                    Array.Resize(ref Keys, Keys.Length - 1);
                    Array.Resize(ref Values, Values.Length - 1);
                    for (int j = 0; j < CopyKeys.Length; j++)
                    {
                        if (CopyKeys[j] != key)
                        {
                            Keys[i] = CopyKeys[i];
                            Values[i] = CopyValues[i];
                        }
                    }
                    return true;
                }
            return false;
        }

        // Сводка:
        //     Получает значение, связанное с указанным ключом.
        // Параметры:
        //   key:
        //     Ключ значения, которое необходимо получить.
        //   value:
        //     Возвращаемое значение, связанное с указанном ключом, если он найден; в противном 
        //случае — значение по умолчанию для данного типа параметра value. Этот параметр передается неинициализированным.
        //   public bool TryGetValue(string key, out double value);
    }
}
