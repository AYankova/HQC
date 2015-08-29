#  Object pool pattern

*     Шаблон за дизайн, който се използва в обектно-ориентираното програмиране, който използва набор от инициализирани обекти, готови за употреба (__pool__), вместо да ги създава и унищожава при поискване. Клиентът на този __pool__ при нужда получава обект от него и извършва някакви действия с получения обект. Когато приключи работа с обекта, клиентът го връща обратно в __pool__-а, а не го унищожава. Това може да бъде направено ръчно или автоматично. Object pools се използват главно за подобряване на производителността.
*     Object pool pattern се използва, когато се налага да работим с голям брой обекти, които струват "скъпо" да се инстанцират и всеки един от обектите ни е нужен за кратък период от време. Този шаблон за дизайн създава набор от обекти, които могат да бъдат преизползвани. Когато нов обект е необходим, той се поисква от този __pool__. Ако такъв обект е вече създаден, той се връща мигновено, като се избягва цената на инстанцирането му. Ако няма обекти в __pool__-а, се създава нов обект и се връща. Когато вече не е необходим този обект, той се връща обратно в __pool__-а, позволявайки той да бъде използван отново в бъдеще, без да се повтаря скъпоструващие процес на инстанциране. След като обекта се върне в __pool__, съществуващите рефернции се премахват. 
*     Object pooling изисква ресурси - памет или други ресурси, напр. сокети, и затова е препоръчително броят на инстанциите в употреба във всеки един момент да е малък, но това не е задължително. Pooled object се получава за предварително известно време, докато създаването на нови обекти (особено през мрежата) може да отнеме различно време. Ползите от този шаблон за дизайн се отнасят най-вече за обекти, чието създаване отнема време, като създаване на връзка към базата данни, сокет конекции, нишки и големи графични обекти като фонтове или битмапове.
*     Когато се имплементира object pool, програмиста трябва да осигури, че състоянието на обекта, който се връща в __pool__-а е  нулирано. Ако това не се съблюдава, обекта често ще бъде състояние, което е неочаквано от клиентската програма и може да доведе до грешни резултати. Самият __pool__ е отговорен за рисетването на обектите, не клиента. Неправилното ресетване на обектите може да причини загуба на информация. Ако __pool__-а се използва от множество нишки, трябва да се предотврати възможността паралени нишки да могат вземат и използват един и същи обект. Това не е необходими, ако обектите в __pool__-а са immutable или thread-safe. 