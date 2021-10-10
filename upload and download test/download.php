<?php $conn = mysqli_connect('localhost','root','','lifeline'); ?>

<?php
    if (isset($_GET['file'])) {
        $id = $_GET['file'];
    
        // fetch file to download from database
        $sql = "SELECT * FROM teacher_assignment_upload WHERE teach_assignment_id=$id";
        $result = mysqli_query($conn, $sql);
    
        $file = mysqli_fetch_assoc($result);
        $filepath = 'uploads/' . $file['file_name'];
    
        if (file_exists($filepath)) {
            header('Content-Description: File Transfer');
            header('Content-Type: application/octet-stream');
            header('Content-Disposition: attachment; filename=' . basename($filepath));
            header('Expires: 0');
            header('Cache-Control: must-revalidate');
            header('Pragma: public');
            header('Content-Length: ' . filesize('uploads/' . $file['file_name']));
            readfile('uploads/' . $file['file_name']);
    
            // Now update downloads count
            // $newCount = $file['downloads'] + 1;
            // $updateQuery = "UPDATE files SET downloads=$newCount WHERE id=$id";
            // mysqli_query($conn, $updateQuery);
            exit;
        }
    
    }

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>upload</title>
</head>
<body>
   
   <table border="1px" align="center">
       <tr>
           <td>
              <?php
               $query2 = "SELECT * FROM teacher_assignment_upload ";
               $run2 = mysqli_query($conn,$query2);
               
               while($rows = mysqli_fetch_assoc($run2)){
                   ?>
               <a href="download.php?file=<?php echo $rows['teach_assignment_id']; ?>&name=<?php echo $rows['file_name']; ?>">Download</a><br>
               <?php
               }
               ?>
           </td>
       </tr>
   </table>
    
</body>
</html>