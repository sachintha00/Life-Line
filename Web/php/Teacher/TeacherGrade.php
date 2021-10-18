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

<?php
    $result = getValue("SELECT * FROM teacher_account WHERE teach_roll_id = '{$_SESSION['id']}'");
    $result2 = getValue("SELECT * FROM subject WHERE `subject` = '{$result['teach_subject']}'");
                                
    $subjectId = $result2['subject_id'];                         

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../../css/Student/StudentMenu.css" type="text/css">
    <link rel="stylesheet" href="../../css/navigationBarStyle.css" type="text/css">
    <link rel="stylesheet" href="../../css/Teacher/TeacherGrads.css" type="text/css">
    <title>Document</title>
</head>
<body>

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
                    <li><img src="../../resource/Profile DashBoard.png" alt=""><a href="TeacherMain.php">Dashboard</a></li>
                    <li><img src="../../resource/editProfile.png" alt=""><a href="../../php/Teacher/profileEdit.php">Edit Profile</a></li>
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
                        <li ><a href="#" class="SignIn-Nav" id="profile" style="text-transform: capitalize;"><?php echo $result['teach_first_name'] ?></a></li>
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
                            <h1 style="text-transform: capitalize;"><?php echo $result['teach_first_name'] ?></h1></a>
                    <i><a href=""><img src="../../resource/Arrow.png" alt="" class="menu-toggle"></a></i>
                </li>
            
            <div class="menu-items">

                <li class="dashboard">
                    <a href="../Teacher/TeacherMain.php" class="item list btn">
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
                    <a href="../Teacher/TeacherGrade.php" class="item list">
                        <i><img src="../../resource/Subject.png" alt=""></i>
                        <span>Grades</span>
                    </a>
                </li><!--li class="Subjects"-->

            </div><!--div class="menu-items"-->

        </ul>
    </nav>

    <!-- Menu end -->

    <div class="topicAndDescript">
        <h1>Grades</h1>
        <p>All the grades related to the subject you choose are given in this section. Use this to get yuour work done efficieantly</p>
    </div><!--div class="topicAndDescript"-->

    <div class="page-wrapper">

        <div class="StSubjects">
            <div class="subjectTopic">
                <h1>All Subjects</h1>
                <p>here are all the feades that apply to you. <br>Enter the grade you want</p>
            </div>
            <div class="allSub">
                <div class="sub Eng" >
                    <a href="../Assigment/TeacherGradeInside.php?grade=Grade6">
                        <h1>Grade 6</h1>
                        <p>Click on this to<br>enter the grades</p>
                        <img src="../../resource/chart.png" alt="" srcset="">
                    </a>
                </div><!--div class="sub Eng"-->
    
                <div class="sub Sci">
                    <a href="../Assigment/TeacherGradeInside.php?grade=Grade7">
                        <h1>Grade 7</h1>
                        <p>Click on this to<br>enter the grades</p>
                        <img src="../../resource/chart.png" alt="" srcset="">
                    </a>
                </div><!--div class="sub Sci"-->
    
                <div class="sub Math">
                    <a href="../Assigment/TeacherGradeInside.php?grade=Grade8">
                        <h1>Grade 8</h1>
                        <p>Click on this to<br>enter the grades</p>
                        <img src="../../resource/chart.png" alt="" srcset="">
                    </a>
                </div><!--div class="sub Math"-->
    
                <div class="sub Sinhala">
                    <a href="../Assigment/TeacherGradeInside.php?grade=Grade9">
                        <h1>Grade 9</h1>
                        <p>Click on this to<br>enter the grades</p>
                        <img src="../../resource/chart.png" alt="" srcset="">
                    </a>
                </div><!--div class="sub Sinhala"-->
    
                <div class="sub Religion">
                    <a href="../Assigment/TeacherGradeInside.php?grade=Grade10">
                        <h1>Grade 10</h1>
                        <p>Click on this to<br>enter the grades</p>
                        <img src="../../resource/chart.png" alt="" srcset="">
                    </a>
                </div><!--div class="sub Religion"-->
    
                <div class="sub Hist">
                    <a href="../Assigment/TeacherGradeInside.php?grade=Grade11">
                        <h1>Grade 11</h1>
                        <p>Click on this to<br>enter the grades</p>
                        <img src="../../resource/chart.png" alt="" srcset="">
                    </a>
                </div><!--div class="sub Hist"-->
    
            </div>

        </div><!--div class="Subjects"-->

        <div class="ExamTimeTable">
            <div class="tableName">
                <h1>SUBMITED ASSIGNMENTS</h1>
            </div>
            <div class="tableStyle">
                <table class="content-tabel">
                    <thead>
                        <tr>
							<th>Assignment NO</th>
							<th>Assignment Name</th>
							<th>Student ID</th>
							<th>Student Name</th>
						</tr>
					</thead>
                    <tbody>
                    <?php
                        $result_set = getResultSet("SELECT * FROM `student_assignment_upload` WHERE subject_id = '{$subjectId}'");

                        foreach($result_set as $result){
                            $result2 = getValue("SELECT * FROM student_account WHERE `st_roll_id` = '{$result['student_ID']}'");                                          
                            $srudentName = $result2['st_first_name']." ".$result2['st_middle_name'];   
                    ?>
                        <tr>
                            <td><?php echo $result['st_assignment_id']; ?></td>
                            <td><?php echo $result['file_name']; ?></td>
                            <td><?php echo $result['student_ID']; ?></td>
                            <td><?php echo $srudentName; ?></td>
                        </tr>
                    <?php   } ?>
                    </tbody>
                </table>
            </div>
        </div><!--div class="ExamTimeTable"-->

        <div class="alertMessageSubject">
            
            <div class="alerts">
                <div class="alertTopic">
                    <h1>All Subjects</h1>
                    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. <br>Et, libero?</p>
                </div>
                <div class="allAlert">
                    <div class="sub" >
                        <a href="#">
                            <h1>Grade 6</h1>
                            <p>Lorem ipsum dolor <br>sit amet.</p>
                            <img src="../../resource/chart.png" alt="" srcset="">
                        </a>
                    </div>

    
                </div><!--div class="alerts"->

        </div><!--div class="alertMessageSubject"-->

        <div class="downloadTimeTable">
            <div class="input-box">
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Est, similique?</p>
                <button name="downloadTimeTable" id="downloadTimeTable">Download Time Table</button>
            </div>
        </div>


    </div><!--div class="page-wrapper"-->

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