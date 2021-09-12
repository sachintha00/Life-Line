<?php 
require_once('../Connection.php');
include('../logic.php'); 
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


<?php 

    $assignment = (int)getRowCount("SELECT COUNT(*) as count FROM `teacher_assignment_upload` WHERE subject_id = '{$subjectId}'");
    $notes = (int)getRowCount("SELECT COUNT(*) as count FROM `teacher_note_upload` WHERE subject_id = '{$subjectId}'");

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../../css/Student/StudentMenu.css" type="text/css">
    <link rel="stylesheet" href="../../css/navigationBarStyle.css" type="text/css">
    <link rel="stylesheet" href="../../css/Teacher/TeacherDashboardStyle.css" type="text/css">
    <link rel="stylesheet" href="../../css/Student/AllStyle.css" type="text/css">
    <link rel="stylesheet" href="../../css/ScrollAdd.css" type="text/css">
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <script type="text/javascript">
      google.charts.load('current', {'packages':['bar']});
      google.charts.setOnLoadCallback(drawChart);

      function drawChart() {
        var data = google.visualization.arrayToDataTable([
          ['Year', 'All Student', 'Assignment Submitted Student'],
          ['Grade 6', '<?php echo (int)getRowCount("SELECT COUNT(*) as count FROM `student_account` WHERE st_Grade = 'Grade6'"); ?>', '<?php echo (int)getRowCount("SELECT `st_assignment_id`, COUNT(*) as count FROM `student_assignment_upload` WHERE subject_id = '{$subjectId}' AND grade = 'Grade6' GROUP BY st_assignment_id "); ?>'],
          ['Grade 7', '<?php echo (int)getRowCount("SELECT COUNT(*) as count FROM `student_account` WHERE st_Grade = 'Grade7'"); ?>', '<?php echo (int)getRowCount("SELECT `st_assignment_id`, COUNT(*) as count FROM `student_assignment_upload` WHERE subject_id = '{$subjectId}' AND grade = 'Grade7' GROUP BY st_assignment_id "); ?>'],
          ['Grade 8', '<?php echo (int)getRowCount("SELECT COUNT(*) as count FROM `student_account` WHERE st_Grade = 'Grade8'"); ?>', '<?php echo (int)getRowCount("SELECT `st_assignment_id`, COUNT(*) as count FROM `student_assignment_upload` WHERE subject_id = '{$subjectId}' AND grade = 'Grade8' GROUP BY st_assignment_id "); ?>'],
          ['Grade 9', '<?php echo (int)getRowCount("SELECT COUNT(*) as count FROM `student_account` WHERE st_Grade = 'Grade9'"); ?>', '<?php echo (int)getRowCount("SELECT `st_assignment_id`, COUNT(*) as count FROM `student_assignment_upload` WHERE subject_id = '{$subjectId}' AND grade = 'Grade9' GROUP BY st_assignment_id "); ?>'],
          ['Grade 10', '<?php echo (int)getRowCount("SELECT COUNT(*) as count FROM `student_account` WHERE st_Grade = 'Grade10'"); ?>', '<?php echo (int)getRowCount("SELECT `st_assignment_id`, COUNT(*) as count FROM `student_assignment_upload` WHERE subject_id = '{$subjectId}' AND grade = 'Grade10' GROUP BY st_assignment_id "); ?>'],
          ['Grade 11', '<?php echo (int)getRowCount("SELECT COUNT(*) as count FROM `student_account` WHERE st_Grade = 'Grade11'"); ?>', '<?php echo (int)getRowCount("SELECT `st_assignment_id`, COUNT(*) as count FROM `student_assignment_upload` WHERE subject_id = '{$subjectId}' AND grade = 'Grade11' GROUP BY st_assignment_id "); ?>']
        ]);

        var options = {
            width: 700,
          chart: {
            title: 'ALL STUDENT AND SUBMITED ASSIGNMENTS',
            subtitle: 'This chart shows who has submitted the assignment',
          },
          colors: ['#273889','#206491']
        };

        var chart = new google.charts.Bar(document.getElementById('top_x_div'));

        chart.draw(data, google.charts.Bar.convertOptions(options));
      }
    </script>

<script type="text/javascript">
        google.charts.load("current", {packages:["corechart"]});
        google.charts.setOnLoadCallback(drawChart);
        function drawChart() {
            var data = google.visualization.arrayToDataTable([
                ['Task', 'Hours per Day'],
                ['Grade 6', <?php echo (int)getRowCount("SELECT `st_assignment_id`, COUNT(*) as count FROM `student_assignment_upload` WHERE subject_id = '{$subjectId}' AND grade = 'Grade6' GROUP BY st_assignment_id "); ?>],
                ['Grade 7', <?php echo (int)getRowCount("SELECT `st_assignment_id`, COUNT(*) as count FROM `student_assignment_upload` WHERE subject_id = '{$subjectId}' AND grade = 'Grade7' GROUP BY st_assignment_id "); ?>],
                ['Grade 8', <?php echo (int)getRowCount("SELECT `st_assignment_id`, COUNT(*) as count FROM `student_assignment_upload` WHERE subject_id = '{$subjectId}' AND grade = 'Grade8' GROUP BY st_assignment_id "); ?>],
                ['Grade 9', <?php echo (int)getRowCount("SELECT `st_assignment_id`, COUNT(*) as count FROM `student_assignment_upload` WHERE subject_id = '{$subjectId}' AND grade = 'Grade9' GROUP BY st_assignment_id "); ?>],
                ['Grade 10', <?php echo (int)getRowCount("SELECT `st_assignment_id`, COUNT(*) as count FROM `student_assignment_upload` WHERE subject_id = '{$subjectId}' AND grade = 'Grade10' GROUP BY st_assignment_id "); ?>],
                ['Grade 11', <?php echo (int)getRowCount("SELECT `st_assignment_id`, COUNT(*) as count FROM `student_assignment_upload` WHERE subject_id = '{$subjectId}' AND grade = 'Grade11' GROUP BY st_assignment_id "); ?>]
            ]);

            var options = {
            title: 'Assignment Completed Students by Grade',
            pieHole: 0.3,
            titleTextStyle: { fontSize: 20,color: '#7b7b7b' },
            slices: {
                0: { color: '#273889' },
                1: { color: '#45AAB4' },
                2: { color: '#038DB2' },
                3: { color: '#206491' },
                4: { color: '#FBB45C' },
                5: { color: '#FE7966' }
            }
            };

            var chart = new google.visualization.PieChart(document.getElementById('countDownload'));
            chart.draw(data, options);
        }
    </script>
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
                        <li ><a href="#" id="profile">Sign In</a></li>
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

    <div class="page-wrapper">

        <div class="allBox">

            <div class="welcome-area">
                <div class="stdash1">
                    <img src="../../resource/studentDash1.png" alt="" id="stdash1">
                </div>
                <img src="../../resource/studentDash.svg" alt="" id="stdash2">
            </div><!--div class="welcome-area"-->


            <div class="prgrssEvents">

                <div class="progress PEbox">
                    <h3>Your Progress</h3>
                    <div class="subectWithProgrss">
                        <div class=" sub grd6">
                            <a href="../Assigment/TeacherGradeInside.php?grade=Grade6" class="subectProgress">
                                <h1>Grade 6</h1>
                                <p>Lorem ipsum dolor <br>sit amet.</p>
                                <img src="../../resource/assignments.png" alt="" srcset="">
                            </a>
                        </div><!--div class=" sub Eng"-->

                        <div class="sub grd7">
                            <a href="../Assigment/TeacherGradeInside.php?grade=Grade7" class="subectProgress">
                                <h1>Grade 7</h1>
                                <p>Lorem ipsum dolor <br>sit amet.</p>
                                <img src="../../resource/assignments.png" alt="" srcset="">
                            </a>
                        </div><!--div class="sub Sci"-->

                        <div class="sub grd8">
                            <a href="../Assigment/TeacherGradeInside.php?grade=Grade8" class="subectProgress">
                                <h1>Grade 8</h1>
                                <p>Lorem ipsum dolor <br>sit amet.</p>
                                <img src="../../resource/assignments.png" alt="" srcset="">
                            </a>
                        </div><!--div class="sub Math"-->

                        <div class="sub grd9">
                            <a href="../Assigment/TeacherGradeInside.php?grade=Grade9" class="subectProgress">
                                <h1>Grade 9</h1>
                                <p>Lorem ipsum dolor <br>sit amet.</p>
                                <img src="../../resource/assignments.png" alt="" srcset="">
                            </a>
                        </div><!--div class="sub Sinhala"-->

                        <div class="sub grd10">
                            <a href="../Assigment/TeacherGradeInside.php?grade=Grade10" class="subectProgress">
                                <h1>Grade 10</h1>
                                <p>Lorem ipsum dolor <br>sit amet.</p>
                                <img src="../../resource/assignments.png" alt="" srcset="">
                            </a>
                        </div><!--div class="sub Religion"-->

                        <div class="sub grd11">
                            <a href="../Assigment/TeacherGradeInside.php?grade=Grade11" class="subectProgress">
                                <h1>Grade 11</h1>
                                <p>Lorem ipsum dolor <br>sit amet.</p>
                                <img src="../../resource/assignments.png" alt="" srcset="">
                            </a>
                        </div><!--div class="sub Hist"-->

                    </div><!--div class="subectWithProgrss"-->
                </div><!--div class="progress PEbox"-->

                <div class="grdePercentage PEbox">
                    <div class="alertBox" style="background-color: #094C9B;">
                        <h3>Grade 6</h3>
                        <p>Completed Student</p>
                        <h6><?php echo (int)getRowCount("SELECT `st_assignment_id`, COUNT(*) as count FROM `student_assignment_upload` WHERE subject_id = '{$subjectId}' AND grade = 'Grade6' GROUP BY st_assignment_id "); ?></h6>
                        <img src="../../resource/attendance.png" alt="">
                    </div>
                    <div class="alertBox" style="background-color: #206491;">
                        <h3>Grade 7</h3>
                        <p>Completed Student</p>
                        <h6><?php echo (int)getRowCount("SELECT `st_assignment_id`, COUNT(*) as count FROM `student_assignment_upload` WHERE subject_id = '{$subjectId}' AND grade = 'Grade7' GROUP BY st_assignment_id "); ?></h6>
                        <img src="../../resource/attendance.png" alt="">
                    </div>
                    <div class="alertBox" style="background-color: #094C9B">
                        <h3>Grade 8</h3>
                        <p>Completed Student</p>
                        <h6><?php echo (int)getRowCount("SELECT `st_assignment_id`, COUNT(*) as count FROM `student_assignment_upload` WHERE subject_id = '{$subjectId}' AND grade = 'Grade8' GROUP BY st_assignment_id "); ?></h6>
                        <img src="../../resource/attendance.png" alt="">
                    </div>
                    <div class="alertBox" style="background-color: #206491;">
                        <h3>Grade 9</h3>
                        <p>Completed Student</p>
                        <h6><?php echo (int)getRowCount("SELECT `st_assignment_id`, COUNT(*) as count FROM `student_assignment_upload` WHERE subject_id = '{$subjectId}' AND grade = 'Grade9' GROUP BY st_assignment_id "); ?></h6>
                        <img src="../../resource/attendance.png" alt="">
                    </div>
                    <div class="alertBox" style="background-color: #094C9B;">
                        <h3>Grade 10</h3>
                        <p>Completed Student</p>
                        <h6><?php echo (int)getRowCount("SELECT `st_assignment_id`, COUNT(*) as count FROM `student_assignment_upload` WHERE subject_id = '{$subjectId}' AND grade = 'Grade10' GROUP BY st_assignment_id "); ?></h6>
                        <img src="../../resource/attendance.png" alt="">
                    </div>
                    <div class="alertBox" style="background-color: #206491;">
                        <h3>Grade 11</h3>
                        <p>Completed Student</p>
                        <h6><?php echo (int)getRowCount("SELECT `st_assignment_id`, COUNT(*) as count FROM `student_assignment_upload` WHERE subject_id = '{$subjectId}' AND grade = 'Grade11' GROUP BY st_assignment_id "); ?></h6>
                        <img src="../../resource/attendance.png" alt="">
                    </div>
                </div><!--div class="Events"-->
    
                <div class="Events Barchart">
                    <div id="top_x_div" style="width: 500px; height: 500px;"></div>
                </div><!--div class="Events"-->
                

            </div><!--div class="prgrssEvents"-->

            <div class="RankAttendance">
            <div class="iconRank"><img src="../../resource/attendance.png" alt=""></div>
                <div class="rnkTopic">
                    <h4>All Asignments</h4>
                    <h5><?php echo $assignment; ?></h5>
                </div>
                <div class="rank">
                    <img src="../../resource/rank.png" alt="">
                </div><!--div class="rank"-->

                <div class="iconAttendance"><img src="../../resource/attendance.png" alt=""></div>
                <div class="attenTopic">
                    <h4>All Notes</h4>
                    <h5><?php echo $notes; ?></h5>
                </div>
                <div class="attendance">
                    <img src="../../resource/rank.png" alt="">
                </div><!--div class="attendance"-->

            </div><!--div class="RankAttendance"-->

            <div class="chartUsingDownload" id="countDownload"></div>

        </div><!--div class="allBox"--> 

        <div class="space"></div>

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

    <script src="../../js/Student/StudentMenu.js"></script>
    <script src="../../js/Student/studentProfile.js"></script>
</body>
</html>