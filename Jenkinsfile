pipeline{  
   agent any
   //enviroment{
     // REGISTRY = "mvcitytech"
     // APPNAME = "Lab01"
     // IMAGE = "Lab01"
     // DOCKER_HUB_LOGIN = credentials('dockerhub-mvcitytech')
    //  }
   stages {
   stage("Build Image"){
   steps{  
   sh "pwd"
   sh 'docker build -t Lab01:10 .'
   }
   }
  }
  
  }
