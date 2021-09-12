<?php require_once('connection.php'); ?>

<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<link rel="stylesheet" href="style.css" type="text/css">
	<link rel="stylesheet" href="">
	<title>Document</title>
</head>
<body>
		<div class="apoinments">
			<div>
				<h2>Doctor Details</h2>
			</div>
			<div class="table-style">
				<table class="content-tabel">
					<thead>
						<tr>
							<th>Doctor Name</th>
							<th>Date</th>
							<th>Appoinments</th>
						</tr>
					</thead>
					<tbody>
						<?php
    						$query = "SELECT name,date,type FROM test";

    						$result_set = mysqli_query($connection,$query);

    						if($result_set)
    						{
        						echo mysqli_num_rows($result_set) . " found data";

								echo "";

								while($records = mysqli_fetch_assoc($result_set))
								{
									echo "<tr> <td>". $records['name'] ." </td> <td> ".$records['date'] ."</td> <td>". $records['type'] . "</td></tr>";
								}
							}?>
					</tbody>
				</table>
			</div>
		</div>
	
</body>
</html>
<?php mysqli_close($connection); ?>