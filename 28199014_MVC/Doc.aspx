<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Doc.aspx.cs" Inherits="_28199014_MVC.Doc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background: url('../images/about-bg8.jpg') 50% 0 repeat-y fixed">
    <h1 style="margin:50px 50px 2px 100px">Documentation</h1>
    <br />
    <hr style="border: double black; width:90% ; height:5px; color:black"/>

    <form id="form1" runat="server">
        <div style="font-family:Georgia; padding:50px 100px">
            <h2>Content</h2>
            <ul style="list-style-type:none">
                <li>
                    <a href="#dc1">1.Assignment Information</a>
                </li>
                <li>
                    <a href="#dc2">2.Web Site Design</a>
                </li>
                <ul>
                    <li>
                        <a href="#dc2-1">2.1 Web Page Hierarchy</a>
                    </li>
                    <li>
                        <a href="#dc2-2">2.2 Home Page</a>
                    </li>
                    <li>
                        <a href="#dc2-3">2.3 About Page</a>
                    </li>
                    <li>
                        <a href="#dc2-4">2.4 Contact Page</a>
                    </li>
                    <li>
                        <a href="#dc2-5">2.5 User Management</a>
                    </li>
                    <li>
                        <a href="#dc2-6">2.6 Cat Management</a>
                    </li>
                    <li>
                        <a href="#dc2-7">2.7 Order Management</a>
                    </li>
                    <li>
                        <a href="#dc2-8">2.8 Error Pages</a>
                    </li>
                </ul>
            </ul>

            <h2 id="dc1">1.Assignment Information</h2>
            <table >
                <tbody>
                    <tr>
                        <td>
                            <b>Author</b>
                        </td>
                        <td>
                            <span style="font-family:Georgia">Ding YaLei</span> ID:28199014, Email:<a href="mailto:Ydin0002@student.monash.edu">Ydin0002@student.monash.edu</a>
                            <br />
                            <span style="font-family:Georgia">Zheng Xuan</span> ID:28198840, Email:<a href="mailto:xzhe0001@student.monash.edu">xzhe0001@student.monash.edu</a>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Unit Name:</b>
                        </td>
                        <td>
                            Enterprise and Internet Applications Development
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Unit Code:</b>
                        </td>
                        <td>
                            FIT5192
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Unit Provider:</b>
                        </td>
                        <td>
                            Monash University, the Caulfield School of Information Technology
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Assignment Number:</b>
                        </td>
                        <td>
                            Assignment 2
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Date of Submission:</b>
                        </td>
                        <td>
                            Aug. 2017
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Lecture/Tutor:</b>
                        </td>
                        <td>
                            Jue (Grace) XIE
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <b>Division of Labour:</b>
                        </td>
                        <td>
                            <b>Ding YaLei</b>
                            Page edit, Table Edit, Data Picker.
                            <br />
                            <b>Zheng Xuan</b>
                            Database, Validation, Suggestions.
                            <br />
                            Documentation together.

                        </td>
                    </tr>
                </tbody>
            </table>
            <p></p>
            <p></p>

            <h2 id="dc2">2.Web Site Design</h2>
            <h3 id="dc2-1">2.1 Web Site Hierarchy</h3>
            <p>
                <img src="Doc/hierarchy.png" style="width:50%; margin-left:50px"/>
            </p>

            <h3 id="dc2-2">2.2 Home Page</h3>
            <p>
                <b>Note:</b>
            </p>
            <p>
                <img src="Doc/homepage.png" style="width:55%; margin-left:50px"/>
            </p>

            <h3 id="dc2-3">2.3 About Page</h3>
            <p>Some static pages, just show below.</p>
            <p>
                <img src="Doc/aboutUs.png" style="width:55%; margin-left:50px"/>
            </p>

            <h3 id="dc2-4">2.4 Contact System</h3>
            <p>Some static pages, just show below.</p>
            <p>
                <img src="Doc/contact.png" style="width:55%; margin-left:50px"/>
            </p>

            <h3 id="dc2-5">2.5 User Management</h3>
            <p>Some static pages, just show below.</p>
            <img src="Doc/displayUser.png" style="width:69%; margin-left:50px" />
            <br />

            <img src="Doc/addUser.png" style="width:57.5%; margin-left:50px; margin-top:30px" />
            <br />
            <img src="Doc/editUser.png" style="width:56%; margin-left:50px; margin-top:30px"/>
            <br />
            <img src="Doc/detailUser.png" style="width:55%; margin-left:50px; margin-top:30px"/>
            <br />
            <img src="Doc/deleteUser.png" style="width:60%; margin-left:50px; margin-top:30px"/>
            <br />

            <h3 id="dc2-6">2.6 Cat Management</h3>
            <p>Amost the same as the User Pages.</p>

            <h3 id="dc2-7">2.7 Order Management</h3>
            <p>Amost the same as the User Pages, just show below.</p>
            <img src="Doc/diaplayOrder.png" style="width:55%; margin-left:50px"/>
            <br />
                
            <h3 id="dc2-8">2.8 Error Pages</h3>
            <p>When the request failed, the page will jump to error pages. These pages also provide the button to return to HomePage</p>
            
            <img src="Doc/404notfound.png" style="width:55%; margin-left:50px; margin-top:30px"/>
            <br />
            <img src="Doc/error.png" style="width:55%; margin-left:50px; margin-top:30px"/>
            <br />
        
        
        </div>
    </form>
</body>
</html>
