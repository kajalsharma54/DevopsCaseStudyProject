node {
  stage('SCM') {
    checkout scm
  }
  stage('SonarQube Analysis') {
    def scannerHome = tool 'SonarScanner for MSBuild'
    withSonarQubeEnv() {
      bat "${scannerHome}\\SonarScanner.MSBuild.exe begin /k:\"DevopsCaseStudyProject\""
      bat "dotnet build"
      bat "${scannerHome}\\SonarScanner.MSBuild.exe end"
    }
  }
}
