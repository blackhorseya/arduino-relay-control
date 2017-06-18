<?php
$config['db']['dsn']='mysql:host=localhost;dbname=8051_test;charset=utf8';
$config['db']['user'] = 'root';
$config['db']['password'] = 'c13579';

$db = new PDO(
	$config['db']['dsn'],
	$config['db']['user'] ,
	$config['db']['password'],
	array(
		PDO::ATTR_EMULATE_PREPARES => false,
		PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION
	)
);
?>