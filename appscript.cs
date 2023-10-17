// function doGet(e) { 
//   Logger.log( JSON.stringify(e) );  // view parameters
//   var result = 'Ok'; // assume success
//   if (e.parameter == 'undefined') {
//     result = 'No Parameters';
//   }
//   else {
//     var sheet_id = '1JlVv88__0C_ttk5-dTRs6ZnaOfrdXzfGtWI-Dcw1AFk'; 		// Spreadsheet ID
//     var sheet = SpreadsheetApp.openById(sheet_id).getActiveSheet();		// get Active sheet
//     var newRow = sheet.getLastRow() + 1;						
//     var rowData = [];
//     for (var param in e.parameter) {
//       Logger.log('In for loop, param=' + param);
//       var value = stripQuotes(e.parameter[param]);
//       Logger.log(param + ':' + e.parameter[param]);
//       switch (param) {
//         case 'Temperature': //Parameter
//           rowData[0] = value; //Value in column A
//           result = 'Written on column A';
//           break;
//         case 'Humidity': //Parameter
//           rowData[1] = value; //Value in column B
//           result += ' ,Written on column B';
//           break;  
//         default:
//           result = "unsupported parameter";
//       }
//     }
//     Logger.log(JSON.stringify(rowData));
//     // Write new row below
//     var newRange = sheet.getRange(newRow, 1, 1, rowData.length);
//     newRange.setValues([rowData]);
//   }
//   // Return result of operation
//   firestore();
//   return ContentService.createTextOutput(result);
// }
// /**
// * Remove leading and trailing single or double quotes
// */
// function stripQuotes( value ) {
//   return value.replace(/^["']|['"]$/g, "");
// }

// function firestore(){
// //add firebase library to script before running the code
// //get firebase project credentials from GCP and add data from the created json key below
//    const email = "firebase-adminsdk-4978y@sensordata-5b22b.iam.gserviceaccount.com";
//    const key =   "-----BEGIN PRIVATE KEY-----\nMIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQC+8XY18yTkKP6a\n1iSvF2R6FD7209nOj7iLAfQ3bSwxJEFbC0en45H7hR0L7UEt6xCxsRycms0K9xqx\nD/5iSuxioa/ItA20HF3xwymD8g93d2lurLj4xskJFkkBrqAWgRCxTwUebCpiV2zb\nfao/LnSG/mhEiLiJGI7vrn4D5e6ojJ7jkRFHV6WLJrBQVC0l7hY6D8gf8MkxdAqD\n/svlvxyP2spmojJmfPbaIxVVJwNJrX3GS9+A51Hx7bSaE3LMNWuGKcjCADEqTope\n9uAtn7mx8nAQhzr9neJ0b4rqWIX/3zk5yZAXiefN8PySthx8gEEobuzbdgFZp+e6\nl3TVr2y/AgMBAAECggEAXLDOl6XutKuJ3RQzPqP2bKTDZAK3auStyx0ptnZSy5A0\nAcRaBpAcX6Lg1NdZmrbPpdK6dvNWsgn+dRG0hXalhcPDl4SAWnyixifdUWYCSBY5\nojZKnMmy8axVyHFC2WnR9qDLdVdAw/h4qZw5Nu6QNq/tYceU/Uhkqslj9vR5hGvX\n6vJCVQhacpSM6XfxkTSMNtI4T/68oXXDbb45GIiNmtBSdw5iKwcuP9/xBABoX6xh\nlPwyiRTIU75C7SMVUDIOxmv0M0C0A8iQwvKUiLpuYk2yMd60Z0Shb3uVyS/ClLd9\nf9FLGVFnsrrngU9XiIr796NEap/pGKnstFd23MzCoQKBgQDrWEfAlPUSvmHjq6hh\nSdbBjvDIXj35N0wEZY0L0DJf0LStuHvGGsuzONZtI4PbHUqJ4rkLGnG4U0hsJhmt\nYQuEPhfl6S4fBlQphKq9u1osAezvmTmPW+XuFryBOv6GwzVdIboDHPBRLcgpeaso\nqURJDPenPbjdOL15Ygfj+UbmZwKBgQDPs5Etv1GZU4tNHiuili4LHCR+cXrVgwM+\nNXocuocKADMW1+PRbqchjTJzFe3Ltx92XUpx3YJBHfkXwkEsslm5w98jX1K6gdz0\nd3TGYXp1yGLv2loXqvrqBFb9F/aWzVgJ1mBp02A9KRg20+oIy8M/VRIjwZe1tMZn\nFeqEUmzf6QKBgGrUTvXPaBPTEfJb+Hn5H6ALN6dsiCs5e6s/QbBMGKG/xlRZOu4p\nObAoK8Ws6myrNiuzHBY7McXfIC/fd6ZpN+YWnZiCqanxoICcNTkc84iocxor7qHx\nsETMU1NCKUmZEP8ukRZaq4feBU82aIhzlYindz+WV/UrjW6tHjHQ9OsfAoGAWvgq\n/f5tntoYiQ5Nzkg4omURFtBdHGblZLnHYg3QV3D+72JfRbtROEC/d+iC3la2UQFL\nOdPq2Npn3yAVq53x7or7kGKPuWBnhitL2heXqz65FpRsITGh9B0yfGeieSo3BRf/\n4lnSLPdyw5DNUEzuly6LY13HNK6Yt03CCXKQfQECgYAkbnhjvAhs2rQF0y6pKfdw\nNMlQ+WR7Jq1i9pLhUGy7QOK9fMq30DBMBbGnIGShf+6gli12US0hP/ug5ifR+EPj\n4F/eP96PDiUkEQS03Z3XCkl+WVYa3cAsIDF9AweZYFOy6y77D76q6IX21Sxg+xS7\n+vAIhNtT0WD2NFsCV9BIAA==\n-----END PRIVATE KEY-----\n";
//    const projectId = "sensordata-5b22b";
//    var firestore = FirestoreApp.getFirestore (email, key, projectId);

// // get document data from ther spreadsheet
//    var ss = SpreadsheetApp.getActiveSpreadsheet();
//    //Give the sheetname of your spreadsheet
//    var sheetname = "IFTTT_Maker_Webhooks_Events"; 
//    var sheet = ss.getSheetByName(sheetname); 
//    // get the last row and column in order to define range
//    var sheetLR = sheet.getLastRow(); // get the last row
//    var sheetLC = sheet.getLastColumn(); // get the last column
//    var dataSR = 2; // the first row of data
//    // define the data range
//    var sourceRange = sheet.getRange(2,1,sheetLR-dataSR+1,sheetLC);

//    // get the data
//    var sourceData = sourceRange.getValues();
//    // get the number of length of the object in order to establish a loop value
//    var sourceLen = sourceData.length;
  
//   // Loop through the rows
//    for (var i= sourceLen-1;i<sourceLen;i++){
//      if (sourceData[i][1] !=='') {
//        var data = {};
       
//       data.timestamp = sourceData[i][0];
//        data.heartrate=sourceData[i][1];
//        firestore.createDocument("datalog",data);

//      } 
    
//   }
// }


//Adding all rows
function doGet(e) { 
  Logger.log( JSON.stringify(e) );  // view parameters
  var result = 'Ok'; // assume success
  if (e.parameter == 'undefined') {
    result = 'No Parameters';
  }
  else {
    var sheet_id = '1JlVv88__0C_ttk5-dTRs6ZnaOfrdXzfGtWI-Dcw1AFk'; 		// Spreadsheet ID
    var sheet = SpreadsheetApp.openById(sheet_id).getActiveSheet();		// get Active sheet
    var newRow = sheet.getLastRow() + 1;						
    var rowData = [];
    for (var param in e.parameter) {
      Logger.log('In for loop, param=' + param);
      var value = stripQuotes(e.parameter[param]);
      Logger.log(param + ':' + e.parameter[param]);
      switch (param) {
        case 'Temperature': //Parameter
          rowData[0] = value; //Value in column A
          result = 'Written on column A';
          break;
        case 'Humidity': //Parameter
          rowData[1] = value; //Value in column B
          result += ' ,Written on column B';
          break;  
        default:
          result = "unsupported parameter";
      }
    }
    Logger.log(JSON.stringify(rowData));
    // Write new row below
    var newRange = sheet.getRange(newRow, 1, 1, rowData.length);
    newRange.setValues([rowData]);
  }
  // Return result of operation
  firestore();
  return ContentService.createTextOutput(result);
}
/**
* Remove leading and trailing single or double quotes
*/
function stripQuotes( value ) {
  return value.replace(/^["']|['"]$/g, "");
}

function firestore(){
//add firebase library to script before running the code
//get firebase project credentials from GCP and add data from the created json key below
   const email = "firebase-adminsdk-4978y@sensordata-5b22b.iam.gserviceaccount.com";
   const key =   "-----BEGIN PRIVATE KEY-----\nMIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQC+8XY18yTkKP6a\n1iSvF2R6FD7209nOj7iLAfQ3bSwxJEFbC0en45H7hR0L7UEt6xCxsRycms0K9xqx\nD/5iSuxioa/ItA20HF3xwymD8g93d2lurLj4xskJFkkBrqAWgRCxTwUebCpiV2zb\nfao/LnSG/mhEiLiJGI7vrn4D5e6ojJ7jkRFHV6WLJrBQVC0l7hY6D8gf8MkxdAqD\n/svlvxyP2spmojJmfPbaIxVVJwNJrX3GS9+A51Hx7bSaE3LMNWuGKcjCADEqTope\n9uAtn7mx8nAQhzr9neJ0b4rqWIX/3zk5yZAXiefN8PySthx8gEEobuzbdgFZp+e6\nl3TVr2y/AgMBAAECggEAXLDOl6XutKuJ3RQzPqP2bKTDZAK3auStyx0ptnZSy5A0\nAcRaBpAcX6Lg1NdZmrbPpdK6dvNWsgn+dRG0hXalhcPDl4SAWnyixifdUWYCSBY5\nojZKnMmy8axVyHFC2WnR9qDLdVdAw/h4qZw5Nu6QNq/tYceU/Uhkqslj9vR5hGvX\n6vJCVQhacpSM6XfxkTSMNtI4T/68oXXDbb45GIiNmtBSdw5iKwcuP9/xBABoX6xh\nlPwyiRTIU75C7SMVUDIOxmv0M0C0A8iQwvKUiLpuYk2yMd60Z0Shb3uVyS/ClLd9\nf9FLGVFnsrrngU9XiIr796NEap/pGKnstFd23MzCoQKBgQDrWEfAlPUSvmHjq6hh\nSdbBjvDIXj35N0wEZY0L0DJf0LStuHvGGsuzONZtI4PbHUqJ4rkLGnG4U0hsJhmt\nYQuEPhfl6S4fBlQphKq9u1osAezvmTmPW+XuFryBOv6GwzVdIboDHPBRLcgpeaso\nqURJDPenPbjdOL15Ygfj+UbmZwKBgQDPs5Etv1GZU4tNHiuili4LHCR+cXrVgwM+\nNXocuocKADMW1+PRbqchjTJzFe3Ltx92XUpx3YJBHfkXwkEsslm5w98jX1K6gdz0\nd3TGYXp1yGLv2loXqvrqBFb9F/aWzVgJ1mBp02A9KRg20+oIy8M/VRIjwZe1tMZn\nFeqEUmzf6QKBgGrUTvXPaBPTEfJb+Hn5H6ALN6dsiCs5e6s/QbBMGKG/xlRZOu4p\nObAoK8Ws6myrNiuzHBY7McXfIC/fd6ZpN+YWnZiCqanxoICcNTkc84iocxor7qHx\nsETMU1NCKUmZEP8ukRZaq4feBU82aIhzlYindz+WV/UrjW6tHjHQ9OsfAoGAWvgq\n/f5tntoYiQ5Nzkg4omURFtBdHGblZLnHYg3QV3D+72JfRbtROEC/d+iC3la2UQFL\nOdPq2Npn3yAVq53x7or7kGKPuWBnhitL2heXqz65FpRsITGh9B0yfGeieSo3BRf/\n4lnSLPdyw5DNUEzuly6LY13HNK6Yt03CCXKQfQECgYAkbnhjvAhs2rQF0y6pKfdw\nNMlQ+WR7Jq1i9pLhUGy7QOK9fMq30DBMBbGnIGShf+6gli12US0hP/ug5ifR+EPj\n4F/eP96PDiUkEQS03Z3XCkl+WVYa3cAsIDF9AweZYFOy6y77D76q6IX21Sxg+xS7\n+vAIhNtT0WD2NFsCV9BIAA==\n-----END PRIVATE KEY-----\n";
   const projectId = "sensordata-5b22b";
   var firestore = FirestoreApp.getFirestore (email, key, projectId);

// get document data from ther spreadsheet
   var ss = SpreadsheetApp.getActiveSpreadsheet();
   //Give the sheetname of your spreadsheet
   var sheetname = "IFTTT_Maker_Webhooks_Events"; 
   var sheet = ss.getSheetByName(sheetname); 
   // get the last row and column in order to define range
   var sheetLR = sheet.getLastRow(); // get the last row
   var sheetLC = sheet.getLastColumn(); // get the last column
   var dataSR = 2; // the first row of data
   // define the data range
   var sourceRange = sheet.getRange(2,1,sheetLR-dataSR+1,sheetLC);

   // get the data
   var sourceData = sourceRange.getValues();
   // get the number of length of the object in order to establish a loop value
   var sourceLen = sourceData.length;
  
  // Loop through the rows
   for (var i= sourceLen-1;i<sourceLen;i++){
     if (sourceData[i][1] !=='') {
       var data = {};
       
      data.timestamp = sourceData[i][0];
      data.temperature=sourceData[i][1];
      data.spo2 = sourceData[i][2];
      data.heartrate=sourceData[i][3];
       firestore.createDocument("patientData",data);

     } 
    
  }
}App script
