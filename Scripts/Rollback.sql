-- settings
PRAGMA foreign_keys=ON;
PRAGMA legacy_alter_table=ON;

drop table if exists testcase_has_steps;
drop table if exists testsuite_has_testcases;
drop table if exists testcases;
drop table if exists testsuites; 
drop view if exists view_testcases;
drop view if exists view_testsuites;


-- one time scripts

drop table if exists progress;

create table progress (
	id integer primary key,
	user_login text,
	run_id integer,
	testcase_short_id integer,
	foreign key (testcase_short_id) references testcases(short_id));

-- tables

create table testcases (
	short_id integer primary key,
	title text,
	idea text,
	expected_result text);

create table testsuites (
	short_id integer primary key, 
	title text);

-- relational tables

create table testcase_has_steps (
	id integer primary key,
	testcase_short_id integer,
	step number key,
	action text,
	foreign key (testcase_short_id) references testcases(short_id));

create table testsuite_has_testcases (
	id integer primary key,
	testsuite_short_id integer,
	step number,
	testcase_short_id integer,
	foreign key (testsuite_short_id) references testsuites(short_id),
	foreign key (testcase_short_id) references testcases(short_id));
	
-- views

create view if not exists view_testcases as
	select
		tc.short_id as short_id,
		tc.title as title,
		tc.idea as idea,
		tc.expected_result as expected_result,
		count(step) as qty_of_steps
		from testcases tc
		left outer join testcase_has_steps ths on tc.short_id = ths.testcase_short_id
		group by short_id
		order by short_id asc;

create view if not exists view_testsuites as
	select 
		ts.short_id as short_id,
		ts.title as title,
		count(*) as qty_of_test_cases
		from testsuite_has_testcases tshtc
		inner join testsuites ts on ts.short_id = tshtc.testsuite_short_id
		group by short_id
		order by short_id, step asc;

	