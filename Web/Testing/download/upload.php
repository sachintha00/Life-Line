<?php $conn = mysqli_connect('localhost','root','','lifeline_test'); ?>

<?php
    if (isset($_GET['file'])) {
        $id = $_GET['file'];
    
        // fetch file to download from database
        $sql = "SELECT * FROM filedownload WHERE id=$id";
        $result = mysqli_query($conn, $sql);
    
        $file = mysqli_fetch_assoc($result);
        $filepath = 'uploads/' . $file['fileName'];
    
        if (file_exists($filepath)) {
            header('Content-Description: File Transfer');
            header('Content-Type: application/octet-stream');
            header('Content-Disposition: attachment; filename=' . basename($filepath));
            header('Expires: 0');
            header('Cache-Control: must-revalidate');
            header('Pragma: public');
            header('Content-Length: ' . filesize('uploads/' . $file['fileName']));
            readfile('uploads/' . $file['fileName']);
    
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
   
   <?php
    if(isset($_POST['submit'])){
        $fileName = $_FILES['file']['name'];
        $fileTmpName = $_FILES['file']['tmp_name'];
        $path = "uploads/".$fileName;
        
        $query = "INSERT INTO filedownload(filename) VALUES ('$fileName')";
        $run = mysqli_query($conn,$query);
        
        if($run){
            move_uploaded_file($fileTmpName,$path);
            echo "success";
        }
        else{
            echo "error".mysqli_error($conn);
        }
        
    }
    
    ?>
   
   <table border="1px" align="center">
       <tr>
           <td>
               <form action="upload.php" method="post" enctype="multipart/form-data">
                    <input type="file" name="file">
                    <button type="submit" name="submit"> Upload</button>
                </form>
           </td>
       </tr>
       <tr>
           <td>
              <?php
               $query2 = "SELECT * FROM filedownload ";
               $run2 = mysqli_query($conn,$query2);
               
               while($rows = mysqli_fetch_assoc($run2)){
                   ?>
               <a href="upload.php?file=<?php echo $rows['id'] ?>">Download</a><br>
               <?php
               }
               ?>
           </td>
       </tr>
   </table>
    
</body>
</html>