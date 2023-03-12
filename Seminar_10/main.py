# | Задание 44 |
# | --- |
# | В ячейке ниже представлен код генерирующий DataFrame, которая состоит всего из 1 столбца. 
#Ваша задача перевести его в one hot вид. Сможете ли вы это сделать без get_dummies?

# import random
# lst = ['robot'] * 10
# lst += ['human'] * 10
# random.shuffle(lst)
# data = pd.DataFrame({'whoAmI'lst})
# data.head() |


import pandas as pd
import random

lst = ['robot'] * 10 # 10 роботов в массиве
lst += ['human'] * 10 # 10 человеков добавили
random.shuffle(lst) # перемешали их
data = pd.DataFrame({'whoAmI': lst}) # выводим таблицу
data.head

print('изначальная таблица', '\n', data)

data_g = pd.get_dummies(data, columns=['whoAmI'])
print('таблица с функцией get_dummies', '\n', data_g)

def dumm_diy(lst:list, category:str):
    # функция возвращает массив категорий по совпадениям массива x с category
    return [(1 if item == category else 0) for item in lst]
    
data_h = pd.DataFrame({'human': dumm_diy(lst, 'human'), 'robot': dumm_diy(lst, 'robot')})
print('таблица с самодельной функцией', '\n', data_h)