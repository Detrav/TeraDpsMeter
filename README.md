# TeraDpsMeter
ДПСметер для игры TERA Online

Пока готов только снифер, потестил: примерно 500000 пакетов, примерно 45000 ошибок обработано, ни одного потеряного тера-пакета.
Позже сделаю GUI для снифера

Для работы нужен WinpkFilter 3.2.3, http://www.ntkernel.com/?Products:Development_Toolkits:Windows_Packet_Filter_Kit

Почему не pcap? У pcap'a 5% потеря пакетов, а для расшифровки пакетов теры нужен весь поток данных.

По поводу самого ДПС метра, доделаю как будет время.

Путь: 

-> Сделать GUI

-> Сделать возможность просмотра содержимого пакета

-> Сделать веншние хранение для структур данных пакетов

-> Продумать ДПС метр

-> Расшифровать пакеты необходимые для ДПС метра

-> Написать ДПС метр
