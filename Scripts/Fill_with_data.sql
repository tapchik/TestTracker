-- settings

PRAGMA foreign_keys=ON;
PRAGMA legacy_alter_table=ON;

-- clearing all test data

delete from testcase_has_steps;  
delete from testsuite_has_testcases;
delete from testcases;
delete from testsuites;

-- inserting testcases

insert 
	into testcases (short_id, title, idea, expected_result) 
	values (100, "Авторизация под пользователем", 
		"Вход в систему под пользователем user_one/pA$$woRd",
		"В профиле пользователя в поле 'Имя' написано 'Ваня Пяткин'");

insert 
	into testcases (short_id, title, idea, expected_result)
	values (101, "Авторизация под администратором",
		"Вход в систему под пользователем admin_one/passadmin", 		"В профиле пользователя в поле 'Имя' написано 'Администратор Первый'");

insert 
	into testcases (short_id, title, idea, expected_result)
	values (102, "Поиск товаров по названию",
		"Найти три различных торвара по названию в поиске и добавить их в корзину",
		"В корзине находятся добавленные товары");

insert 
	into testcases (short_id, title, idea, expected_result)
	values (103, "Поиск товаров по производителю",
		"Найти три различных торвара по производителю в поиске и добавить их в корзину",
		"В корзине находятся добавленные товары");

insert 
	into testcases (short_id, title, idea, expected_result)
	values (105, "Оплата покупки картой VISA",
		"Проверка возможности оплатить покупку картой VISA",
		"Заказ оформлен и добавлен в таблицу orders");

insert 
	into testcases (short_id, title, idea, expected_result)
	values (106, "Оплата покупки картой Mastercard",
		"Проверка возможности оплатить покупку картой Mastercard",
		"Заказ оформлен и добавлен в таблицу orders");

insert 
	into testcases (short_id, title, idea, expected_result)
	values (107, "Оплата покупки картой МИР",
		"Проверка возможности оплатить покупку картой МИР",
		"Заказ оформлен и добавлен в таблицу orders");
	
insert 
	into testcases (short_id, title, idea, expected_result)
	values (108, "Вкладки на панели навигации",
		"Проверить работоспособность вкладок на панели меню",
		"Все вкладки на панели меню открываются по щелчку");

insert 
	into testcases (short_id, title, idea, expected_result)
	values (109, "Пункты меню на вкладках",
		"Проверить работоспособность пунктов меню на вкладках",
		"Все пункты меню открываются по щелчку");

	
-- inserting testsuite

insert into testsuites values (201, "Авторизация на сайте");
insert into testsuite_has_testcases (testsuite_short_id, step, testcase_short_id) values (201, 1, 100);
insert into testsuite_has_testcases (testsuite_short_id, step, testcase_short_id) values (201, 2, 101);

insert into testsuites values (202, "Поиск товаров");
insert into testsuite_has_testcases (testsuite_short_id, step, testcase_short_id) values (202, 1, 102);
insert into testsuite_has_testcases (testsuite_short_id, step, testcase_short_id) values (202, 2, 103);

insert into testsuites values (203, "Оплата товаров в корзине");
insert into testsuite_has_testcases (testsuite_short_id, step, testcase_short_id) values (203, 1, 105);
insert into testsuite_has_testcases (testsuite_short_id, step, testcase_short_id) values (203, 2, 106);
insert into testsuite_has_testcases (testsuite_short_id, step, testcase_short_id) values (203, 3, 107);

insert into testsuites values (204, "Панель навигации");
insert into testsuite_has_testcases (testsuite_short_id, step, testcase_short_id) values (204, 1, 108);
insert into testsuite_has_testcases (testsuite_short_id, step, testcase_short_id) values (204, 2, 109);
	

-- inserting testcase_has_steps

insert into testcase_has_steps (testcase_short_id, step, action)
	values (100, 1, "Открыть окно входа в систему");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (100, 2, "Ввести логин user_one и пароль pA$$woRd, нажать 'Вход'");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (100, 3, "Перейти на профиль пользователя в правом верхнем углу");

insert into testcase_has_steps (testcase_short_id, step, action)
	values (101, 1, "Открыть окно входа в систему");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (101, 2, "Ввести логин admin_one и пароль passadmin, нажать 'Вход'");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (101, 3, "Перейти на профиль пользователя в правом верхнем углу");

insert into testcase_has_steps (testcase_short_id, step, action)
	values (102, 1, "Авторзироваться под пользователем");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (102, 2, "Перейти в поиск");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (102, 3, "Ввести любое название товара, добавить в корзину");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (102, 4, "Очистить поиск, ввести любое другое название товара, добавить его в корзину");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (102, 5, "Очистить поиск, ввести ещё одно название товара, добавить его в корзину");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (102, 6, "Перейти в корзину, нажав в верхней панели навигации на соответствующий значёк");

insert into testcase_has_steps (testcase_short_id, step, action)
	values (103, 1, "Авторзироваться под пользователем");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (103, 2, "Перейти в поиск");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (103, 3, "Ввести любого производителя товаров, добавить в корзину любой его товар");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (103, 4, "Очистить поиск, ввести любое другого другого производителя, добавить его товар в корзину");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (103, 5, "Очистить поиск, ввести ещё одного производителя, добавить его товар в корзину");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (103, 6, "Перейти в корзину, нажав в верхней панели навигации на соответствующий значёк");

insert into testcase_has_steps (testcase_short_id, step, action)
	values (105, 1, "Авторзироваться под пользователем");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (105, 2, "Перейти в корзину, через панель навигации");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (105, 3, "В корзине лежит два и более товаров");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (105, 4, "Нажать на кнопку 'Оформить заказ'");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (105, 5, "Ввести данные тестовой карты VISA (см. Conf)");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (105, 6, "Найти в таблице orders оформленный заказ по id из чека"); 
	
insert into testcase_has_steps (testcase_short_id, step, action)
	values (106, 1, "Авторзироваться под пользователем");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (106, 2, "Перейти в корзину, через панель навигации");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (106, 3, "В корзине лежит два и более товаров");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (106, 4, "Нажать на кнопку 'Оформить заказ'");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (106, 5, "Ввести данные тестовой карты Mastercard (см. Conf)");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (106, 6, "Найти в таблице orders оформленный заказ по id из чека"); 
	
insert into testcase_has_steps (testcase_short_id, step, action)
	values (107, 1, "Авторзироваться под пользователем");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (107, 2, "Перейти в корзину, через панель навигации");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (107, 3, "В корзине лежит два и более товаров");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (107, 4, "Нажать на кнопку 'Оформить заказ'");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (107, 5, "Ввести данные тестовой карты Мир (см. Conf)");
insert into testcase_has_steps (testcase_short_id, step, action)
	values (107, 6, "Найти в таблице orders оформленный заказ по id из чека"); 
	

-- inserting progress

insert into progress (user_login, run_id, testcase_short_id, timestamp_started, timestamp_finished, passed) values 
	("tatiana", "bngh34", 102, "2023-03-12", "2023-03-12", "Passed");
insert into progress (user_login, run_id, testcase_short_id, timestamp_started, timestamp_finished, passed) values 
	("tatiana", "bngh34", 103, "2023-03-12", "2023-03-12", "Blocked");