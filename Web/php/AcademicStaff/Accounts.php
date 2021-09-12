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

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../../css/Student/StudentMenu.css" type="text/css">
    <link rel="stylesheet" href="../../css/navigationBarStyle.css" type="text/css">
    <link rel="stylesheet" href="../../css/AcademicStaff/academicStaff.css" type="text/css">
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
                <h3>Sachintha Madhawa</h3>
                <p>Grade 12</p>
                <ul>
                    <li><img src="../../resource/Profile DashBoard.png" alt=""><a href="AcademicMain.php">Dashboard</a></li>
                    <li><img src="../../resource/editProfile.png" alt=""><a href="../../php/AcademicStaff/profileEdit.php">Edit Profile</a></li>
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
                        <li><a href="#">About Us</a></li>
                        <li><a href="#">Contact Us</a></li>
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
                    <a href="../AcademicStaff/AcademicMain.php" class="item list btn">
                        <i><img src="../../resource/dashBoard.png" alt=""></i>
                        <span>Dashboard</span>
                    </a>
                </li><!--li class="dashboard"-->
    
                <li class="Subjects">
                    <a href="../AcademicStaff/Accounts.php" class="item list">
                        <i><img src="../../resource/Subject.png" alt=""></i>
                        <span>Account</span>
                    </a>
                </li><!--li class="Subjects"-->

            </div><!--div class="menu-items"-->

        </ul>
    </nav>

    <!-- Menu end -->

    <div class="page-wrapper">
        <div class="ExamTimeTable">
            <div class="tableName">
                <h1>Exam Result</h1>
            </div>
            <div class="combo-input">
                <select name="selectRoll" id="selectRoll" onchange="changeValue();"> 
                    <option value="Student">Student</option>
                    <option value="Teacher">Teacher</option>
                </select>
            </div>
            <div class="input-box">
                <div class="text-input">
                    <input type="text" required="" name="username">
                    <span class="floatingLabel">Search</span>
                </div>
            </div>
            <div class="tableStyle " id="tblStudent">
                <table class="content-tabel">
                <thead>
						<tr>
							<th>ID</th>
							<th>First Name</th>
							<th>Middle Name</th>
							<th>Surname</th>
							<th>Gender</th>
							<th>Grade</th>
							<th>Gmail</th>
							<th>Mobile Number</th>
						</tr>
					</thead>
                    <tbody>
                    <?php
                        $result_set = getResultSet("SELECT * FROM `student_account`");

                        foreach($result_set as $result){

                    ?>
                        <tr>
                            <td><?php echo $result['st_roll_id']; ?></td>
                            <td><?php echo $result['st_first_name']; ?></td>
                            <td><?php echo $result['st_middle_name']; ?></td>
                            <td><?php echo $result['st_surname']; ?></td>
                            <td><?php echo $result['st_gender']; ?></td>
                            <td><?php echo $result['st_Grade']; ?></td>
                            <td><?php echo $result['gmail']; ?></td>
                            <td><?php echo $result['tp_number']; ?></td>
                        </tr>
                    <?php   } ?>
                    </tbody>
                </table>
            </div>

            <div class="tableStyle hide " id=tblTeacher">
                <table class="content-tabel">
                    <thead>
						<tr>
							<th>ID</th>
							<th>First Name</th>
							<th>Middle Name</th>
							<th>Surname</th>
							<th>Gender</th>
							<th>Subject</th>
							<th>Gmail</th>
							<th>Mobile Number</th>
						</tr>
					</thead>
                    <tbody>
                    <?php
                        $result_set = getResultSet("SELECT * FROM `teacher_account`");

                        foreach($result_set as $result){

                    ?>
                        <tr>
                            <td><?php echo $result['teach_roll_id']; ?></td>
                            <td><?php echo $result['teach_first_name']; ?></td>
                            <td><?php echo $result['teach_middle_name']; ?></td>
                            <td><?php echo $result['teach_surname']; ?></td>
                            <td><?php echo $result['teach_gender']; ?></td>
                            <td><?php echo $result['teach_subject']; ?></td>
                            <td><?php echo $result['gmail']; ?></td>
                            <td><?php echo $result['teach_tp_number']; ?></td>
                        </tr>
                    <?php   } ?>
                    </tbody>
                </table>
            </div>

        </div><!--div class="ExamTimeTable"-->

        <div class="topicAndDescript" id="topicAndDescript">
                <h1>Lorem, ipsum dolor.</h1>
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. 
                    Autem quod excepturi quisquam sit omnis? Voluptatum labore quis <br>impedit itaque fuga
                        Autem quod excepturi quisquam sit omnis? Voluptatum labore quis impedit itaque fuga.</p>
         </div><!--div class="topicAndDescript"-->

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

        let selection = document.getElementById('selectRoll');
        let tblStudent = document.getElementById('tblStudent');
        let tblTeacher = document.querySelector('.hide');

        function changeValue(){
            if(selection.options[selection.selectedIndex].text == 'Student'){
                tblStudent.style.opacity = "1";
                tblTeacher.style.opacity = "0";
            }
            if(selection.options[selection.selectedIndex].text == 'Teacher'){
                tblStudent.style.opacity = "0";
                tblTeacher.style.opacity = "1";
            }
            
        }
        
        
    </script>


    <script src="../../js/Student/studentProfile.js"></script>
    <script src="../../js/Student/StudentMenu.js"></script>
    <script src="../../js/AcademicStaff/academic.js"></script>
</body>
</html>