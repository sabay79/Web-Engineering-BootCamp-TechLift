$(document).ready(function(){
  document.getElementById('gridContainer').style.display = 'none';
});
//Set iFrame Height //
function resizeIframe(iFrameID) {
  $(iFrameID).height($(iFrameID).contents().height());
}

//Hide PREVIOUS button when personal details is on display //
var prevBtn = document.getElementById("prevBtn");
$(document).ready(function(){
  prevBtn.hidden = true;
});
function hidePrevButton(){
  prevBtn.hidden = true;
}
function showPrevButton(){
  prevBtn.hidden = false;
}

//Input Masking //
 $(':input').inputmask();

 //Upload image in box/div on button click//
 $("input[name=img]").change(function () {
  if (this.files && this.files[0]) {
      var reader = new FileReader();

      reader.onload = function (e) {
          var img = $('<img>').attr('src', e.target.result);
          $('#display_image').html(img);
      };
      reader.readAsDataURL(this.files[0]);
  }
});
//Remove Image on button click //
var defaultImage = document.getElementById("profile_pic");
var uploadedImage = document.getElementById("image_input");
removeImage=()=>{
  var img = defaultImage;
  $('#display_image').html(img);
  uploadedImage.value = '';
}
//Hide elements at DOM loading //
$(document).ready(function(){
  document.getElementById('contactDetails').style.display = "none";
});
$(document).ready(function(){
  document.getElementById('educationDetails').style.display = "none";
});

//Show - Hide section on button click //

///Show section on Button Click - Plus Button
function showSection(sectionID)
{
  document.getElementById(sectionID).style.display = "block";
  
}
///Hide section on Button Click - Cancel Button
function hideSection(sectionID){
  let sectionToHide = document.getElementById(sectionID);
  sectionToHide.style.display = "none";
}

//Print value on Input Field //
let fullname = document.getElementById("fullname");
let firstName = document.getElementById('fname').value;
let middleName = document.getElementById('mname').value;
let lastName = document.getElementById('lname').value;
fullname.value = firstName + ' ' + middleName + ' ' + lastName;
function generateFullName(){
  document.getElementById("fullname").value = 
  document.getElementById("fname").value + " " +
  document.getElementById("mname").value + " " +
  document.getElementById("lname").value;
}
//Check condition//
function updateGradingSystem()
{
  let totalGrade = document.getElementById("totalGradeLabel");
  let obtainedGrade = document.getElementById("obtainedGradeLabel");
  if (document.getElementById('cgpaGrading').checked == true) 
  {
    totalGrade.innerText = "Total CGPA";
    obtainedGrade.innerHTML = "Obtained CGPA";
  }
  if (document.getElementById('marksGrading').checked == true) 
  {
    totalGrade.innerText = "Total Marks";
    obtainedGrade.innerHTML = "Obtained Marks";
  }
  if (document.getElementById('percentageGrading').checked == true) 
  {
    totalGrade.innerText = "Total Percentage";
    obtainedGrade.innerHTML = "Obtained Percentage";
  }
}
 
//Show Grid on Submission //

function showGridDisplay()
{

  // var name = document.getElementById('fullname').value;
  // var gridName  = document.getElementById('gridName').value;
  // gridName = name;

  // var gender = document.getElementsByName('gender').checked.value;
  // var gridGender = document.getElementById('gridGender').value;
  // gridGender = gender;

  // var dob = document.getElementById('birthday').value;
  // var gridDOB = document.getElementById('gridDOB').value;
  // gridDOB = gender;

  // function calculateAge(dob) {
  //   var today = new Date();
  //   var birthDate = new Date(dob);
  //   var age = today.getFullYear() - birthDate.getFullYear();
  //   var m = today.getMonth() - birthDate.getMonth();
  //   if (m < 0 || (m === 0 && today.getDate() < birthDate.getDate())) {
  //     age--;
  //   }
  //   return age;
  // }
  // var gridAge = document.getElementById('gridAge');
  // gridAge.value = calculateAge(dob);

  // function getSelectedOption(selectElement, displayElement){
  //   output = selectElement.value;
  //   document.querySelector(displayElement).textContent = output;
  // }
  // var religion = document.querySelector('religion');
  // var gridReligion = document.getElementById('gridReligion').value;
  // getSelectedOption(religion, gridReligion);

  // var country = document.querySelector('country');
  // var gridCountry = document.getElementById('gridCountry').value;
  // getSelectedOption(country, gridCountry);

  // var province = document.querySelector('province');
  // var gridProvince = document.getElementById('gridProvince').value;
  // getSelectedOption(province, gridProvince);

  // var city = document.querySelector('city');
  // var gridCity = document.getElementById('gridCity').value;
  // getSelectedOption(city, gridCity);

  document.getElementById('gridContainer').style.display = 'block';

}


//Tab(Page) Navigation on button Click //