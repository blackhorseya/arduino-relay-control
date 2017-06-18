<?PHP	
require 'model/model.php';
require 'config.php';

if (isset ($_GET['action'])){
	switch($_GET['action']){
		case 'list':
			header('refresh: 2');
			
			$mes = new mes($db);
			$data = $mes->getData();
			
			require 'view/light.php';
			break;
		case 'update':
			$mes = new mes($db);
			$msg = $mes->update($_GET['aa'],$_GET['onoff']);
			
			header("refresh:0; index.php?action=list");
			break;
	}
}else{
	header("refresh:0; index.php?action=list");
}
?>