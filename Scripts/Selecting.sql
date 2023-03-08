-- settings

--PRAGMA foreign_keys = ON; -- 1=ON

-- Checking, selecting 

select * from testcase_has_steps --where testcase_short_id=102
		order by step asc; 

select * from testcase_has_steps --where testcase_short_id=101
	order by testcase_short_id, step asc;

select * from testcases;

select * from testsuites;

select * from testsuite_has_testcases --where testsuite_short_id=1
	order by testsuite_short_id, step asc;

select * from view_testcases

select * from view_testsuites --where short_id=

