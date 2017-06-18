<?php
class mes{
	function __construct(PDO $db){
		$this->db = $db;	
	}
	
	function some_logging_function($log){
		echo 'LOG : ' . $log . '<br />';
	}
	
	function getData() {
		$db = $this->db;
		$stmt = $db->query("SELECT * FROM test_8051");
		return array(
			'data' => $stmt->fetchAll(PDO::FETCH_ASSOC),
			'count' => $stmt->rowCount()//回傳資料數
		);
	}
	
	function check($data){
		if($data == 0){
			$state = "<img src=img/close.jpg>";
			echo $state;
		}else if($data == 1){
			$state = "<img src=img/open.jpg>";
			echo $state;
		}
	}
	
	function check_btn($data){
		if($data == 0){
			$state = "開";
			echo $state;
		}else if($data == 1){
			$state = "關";
			echo $state;
		}
	}
	
	function check_onoff($data,$aa){
		if($data == 0){
			$state = "location.href='index.php?action=update&onoff=1&aa=".$aa;
			echo $state;
		}else if($data == 1){
			$state = "location.href='index.php?action=update&onoff=0&aa=".$aa;
			echo $state;
		}
	}
	
	function update($aa,$onoff){
		$db = $this->db;
		$stmt = $db->prepare("update `test_8051` set $aa = :onoff");
		$stmt->execute(array(
							 ':onoff' => $onoff
		));
		return $db->lastInsertId();
	}
}