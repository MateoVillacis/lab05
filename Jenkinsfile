pipeline{  
   agent any
      enviroment{
         APPNAME = "lab01"
         IMAGE = "lab01"
         VERSION = 11
         REGISTRY = "mvcitytech"
         DOCKER_HUB_LOGIN = credentials('dockerhub-MateoVillacis')
     
      }
   stages {
   stage("Build Image"){
   steps{  
   sh "pwd"
   sh 'docker build -t $REGISTRY/$IMAGE:$VERSION .'
   }
   }
      stage('Docker Push to Docker-hub){
            steps{
               sh 'docker login --username=$DOCKER_HUB_LOGIN_USR --password=$DOCKER_HUB_LOGIN_PSW'
               sh 'docker push $REGISTRY/$APPNAME:$VERSION'
     } 
 }  
            }
  
  }
