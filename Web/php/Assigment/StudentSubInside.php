<?php 
require_once('../Connection.php');
require_once('../logic.php');
session_start();
?>

<?php 
    if(!isset($_SESSION['id'])){
        header("Location:../login.php");
    }
?>

<?php $StudentDetail= getValue("SELECT * FROM `student_account` WHERE st_roll_id = '{$_SESSION['id']}'"); ?>

<?php
    if (isset($_GET['file'])) {
        $id = $_GET['file'];
        
        $sql = "SELECT * FROM `teacher_assignment_upload` WHERE teach_assignment_id = '{$id}'";
        $result = mysqli_query($connection, $sql);
    
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
    
            exit;
        }
    
    }

?>

<?php
    if (isset($_GET['nfile'])) {
        $id = $_GET['nfile'];
        
        $sql = "SELECT * FROM `teacher_note_upload` WHERE teach_note_id = '{$id}'";
        $result = mysqli_query($connection, $sql);
    
        $file = mysqli_fetch_assoc($result);
        $filepath = 'uploads/' . $file['filename'];
    
        if (file_exists($filepath)) {
            header('Content-Description: File Transfer');
            header('Content-Type: application/octet-stream');
            header('Content-Disposition: attachment; filename=' . basename($filepath));
            header('Expires: 0');
            header('Cache-Control: must-revalidate');
            header('Pragma: public');
            header('Content-Length: ' . filesize('uploads/' . $file['filename']));
            readfile('uploads/' . $file['filename']);
    
            exit;
        }
    
    }

?>


<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="../../css/Student/StudentMenu.css" type="text/css">
        <link rel="stylesheet" href="../../css/navigationBarStyle.css" type="text/css">
        <link rel="stylesheet" href="../../css/Student/SubInsideStyle.css" type="text/css">
        <link rel="stylesheet" href="../../css/ScrollAdd.css" type="text/css">
        <title>Document</title>
    </head>
    <body>

        <?php 
            if(isset($_POST['assUpload'])){
                $fileName = $_FILES['ass']['name'];
                $fileTmpName = $_FILES['ass']['tmp_name'];
                $path = "uploads/".$fileName;
                    
                $query = "INSERT INTO `student_assignment_upload`(`subject_id`, `file_name`, `assignment`, `student_ID`, `grade`) VALUES ('{$_GET['subId']}','{$fileName}','{$fileTmpName}','{$StudentDetail['st_roll_id']}','{$StudentDetail['st_Grade']}')";
                $run = mysqli_query($connection,$query);
                    
                if($run){
                    move_uploaded_file($fileTmpName,$path);
                }
            }

        ?>
    
        <header>
            <div class="navigation">
                <div class="logo">
                    <ul class="nav-bar">
                        <li><img src="../../resource/logo.svg" alt="Logo"></li>
                        <li><h1>LIFE LINE</h1></li>
                    </ul>
                </div>
                <div class="menu">
                    <!-- <h3>Sachintha Madhawa</h3>
                    <p>Grade 12</p> -->
                    <ul>
                        <li><img src="../../resource/Profile DashBoard.png" alt=""><a href="StudentMain.php">Dashboard</a></li>
                        <li><img src="../../resource/editProfile.png" alt=""><a href="../../php/Student/profileEdit.php">Edit Profile</a></li>
                        <li><img src="../../resource/signOut.png" alt=""><a href="../logOut.php">Sign Out</a></li>
                        <!-- <li><a href="#">Logout</a></li>
                        <li><a href="#">Logout</a></li> -->
                    </ul>
                </div><!--div class="menu"-->
                <div class="nav-bar">
                    <nav>
                        <ul class="nav-panel">
                            <li><a href="#">Home</a></li>
                            <li><a href="#">Services</a></li>
                            <li><a href="#">Library</a></li>
                            <li ><a href="#" class="SignIn-Nav" id="profile">Sign In</a></li>
                        </ul><!--ul class="nav-panel"-->
                    </nav><!--nav-->
                </div><!--div class="nav-bar"-->
            </div>
        </header>
    
        <!-- Menu Start -->
    
        <nav class="side-menu">
            <ul>
                <li class="logo">
                        <a href="">
                        <div class="mProfileContainer" id="muploaded_image">
                            <div class="mpro" id="mpro">
                                
                            </div>
                        </div><!--div class="ProfileContainer"-->
                            <h1>LIFE LINE</h1></a>
                    <i><a href=""><img src="../../resource/Arrow.png" alt="" class="menu-toggle"></a></i>
                </li>
                
                <div class="menu-items">
    
                    <li class="dashboard">
                        <a href="../Student/StudentMain.html" class="item list btn">
                            <i><img src="../../resource/dashBoard.png" alt=""></i>
                            <span>Dashboard</span>
                        </a>
                    </li><!--li class="dashboard"-->
        
                    <li class="News-Event">
                        <a href="" class="item list">
                            <i><img src="../../resource/Events.png" alt=""></i>
                            <span>News And Events</span>
                        </a>
                    </li><!--li class="News-Event"-->
        
                    <li class="Subjects">
                        <a href="../Student/StudentSubject.html" class="item list">
                            <i><img src="../../resource/Subject.png" alt=""></i>
                            <span>Subjects</span>
                        </a>
                    </li><!--li class="Subjects"-->
    
                </div><!--div class="menu-items"-->
    
            </ul>
        </nav>
    
        <!-- Menu end -->

    <div class="wrapper">
        <div class="main-topic">
            <h1>SUBJECTS</h1>
            <p>All the work related to the subject can be done through this. Download notes and assignments uploaded by teachers. assignments can also be uploaded</p>
        </div>
        <div class="Assignment-table">
            <div class="tableName">
                <h1>Assignment</h1>
            </div>
            <div class="input-box">
                <input type="text" required="" name="username">
                <span class="floatingLabel">Search</span>
            </div><!--div class="input-box"-->
            <div class="tableStyle">
                <table class="content-tabel">
                    <thead>
						<tr>
							<th>Topic</th>
							<th>FIle Name</th>
							<th>Download</th>
						</tr>
					</thead>
                    <tbody>
                    
                    <?php
                        $result_set = getResultSet("SELECT * FROM `teacher_assignment_upload` WHERE subject_id = '{$_GET['subId']}' AND grade = '{$StudentDetail['st_Grade']}'");

                        foreach($result_set as $result){

                    ?>
                        <tr>
                            <td><?php echo $result['teach_assignment_id']; ?></td>
                            <td><?php echo $result['file_name']; ?></td>
                            <td><a href="StudentSubInside.php?file=<?php echo $result['teach_assignment_id']; ?>&subId=<?php echo $_GET['subId']; ?>">Download</a></td>
                        </tr>
                    <?php   } ?>
                    </tbody>
                </table><!--table class="content-tabel"-->
            </div><!--div class="tableStyle"-->
        </div><!--div class="Assignment-table"-->

        <div class="Note-table">
            <div class="tableName">
                <h1>Notes</h1>
            </div>
            <div class="input-box">
                <input type="text" required="" name="search">
                <span class="floatingLabel">Search</span>
            </div><!--div class="input-box"-->
            <div class="tableStyle">
                <table class="content-tabel">
                    <thead>
						<tr>
							<th>Topic</th>
							<th>FIle Name</th>
							<th>Download</th>
						</tr>
					</thead>
                    <tbody>
                    <?php
                        $result_set = getResultSet("SELECT * FROM `teacher_note_upload` WHERE subject_id = '{$_GET['subId']}' AND grade = '{$StudentDetail['st_Grade']}'");

                        foreach($result_set as $result){

                    ?>
                        <tr>
                            <td><?php echo $result['teach_note_id']; ?></td>
                            <td><?php echo $result['filename']; ?></td>
                            <td><a href="StudentSubInside.php?nfile=<?php echo $result['teach_note_id']; ?>&subId=<?php echo $_GET['subId']; ?>">Download</a></td>
                        </tr>
                    <?php   } ?>
                    </tbody>
                </table><!--table class="content-tabel"-->
            </div><!--div class="tableStyle"-->
        </div><!--div class="Note-table"-->

        <div class="fileUpload">
            <div class="headerTopic">
                <h1>Assignment Upload</h1>
                <p>Upload all subject related assignments here.</p>
            </div><!--div class="headerTopic"-->
            <div class="upload-section">
                <form action="StudentSubInside.php?subId=<?php echo $_GET['subId'] ?>" method="post" class="upload-form" enctype="multipart/form-data">
                    <input type="file" name="ass" id="upload">
                    <label for="upload">
                        <img src="" alt="">
                        <p>
                            <strong>Drag and Drop</strong> file here <br>or
                            <span>Browse</span> to begin the upload
                        </p>
                    </label><!--label for="upload"-->
                    <button class="btnUpload" name="assUpload">Upload</button>
                </form>
            </div><!--div class="upload-section"-->
        </div><!--div class="fileUpload"-->

        <div class="space">
            
        </div>
    </div>

    <script>

        function sideBar(){
            var xhttp = new XMLHttpRequest();
            xhttp.onreadystatechange = function(){
                if(this.readyState == 4 && this.status == 200){
                    document.getElementById('mpro').innerHTML = this.responseText;
                }
            }
            xhttp.open("POST","ProfilePic.php",true);
            xhttp.send();
        }

        setInterval(() => {

            sideBar();
        }, 1000);
        
        
    </script>

    <script src="../../js/Student/studentProfile.js"></script>
    <script src="../../js/Student/StudentMenu.js"></script>
</body>
</html>