<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title></title>
</head>

<body>
<table border="1">
    <thead>
        <tr>
            <th>A101</th>
            <th>A102</th>
            <th>A103</th>
            <th>A104</th>
            <th>A105</th>
        </tr>
    </thead>
    <tfoot>
        <tr>
            <td colspan="5" align="center">總共<?php echo $data['count'];?>筆留言</td>
        </tr>
	</tfoot>
    <tbody>
        <?php foreach( $data['data'] as $i => $item ){ ?>
            <tr>
                <td><?php $mes->check($item['A101']);?></td>
                <td><?php $mes->check($item['A102']);?></td>
                <td><?php $mes->check($item['A103']);?></td>
                <td><?php $mes->check($item['A104']);?></td>
                <td><?php $mes->check($item['A105']);?></td>
            </tr>
            <tr>
            	<td align="center"><input type="button" name="btn1" value="<?php $mes->check_btn($item['A101']);?>" align="middle" style="width: 100px; height: 50px; font-size: 24px" onclick="<?php $mes->check_onoff($item['A101'],'A101');?>'" /></td>
                <td align="center"><input type="button" name="btn2" value="<?php $mes->check_btn($item['A102']);?>" align="middle" style="width: 100px; height: 50px; font-size: 24px" onclick="<?php $mes->check_onoff($item['A102'],'A102');?>'" /></td>
                <td align="center"><input type="button" name="btn3" value="<?php $mes->check_btn($item['A103']);?>" align="middle" style="width: 100px; height: 50px; font-size: 24px" onclick="<?php $mes->check_onoff($item['A103'],'A103');?>'" /></td>
                <td align="center"><input type="button" name="btn4" value="<?php $mes->check_btn($item['A104']);?>" align="middle" style="width: 100px; height: 50px; font-size: 24px" onclick="<?php $mes->check_onoff($item['A104'],'A104');?>'" /></td>
                <td align="center"><input type="button" name="btn5" value="<?php $mes->check_btn($item['A105']);?>" align="middle" style="width: 100px; height: 50px; font-size: 24px" onclick="<?php $mes->check_onoff($item['A105'],'A105');?>'" /></td>
            </tr>
        <?php } ?>
    </tbody>
</table>
</body>
</html>