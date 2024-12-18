pipeline {
    agent any

    stages {
        stage('Packaging') {
            steps {
                    sh 'docker build --pull --rm -f Dockerfile -t convocationcheckin:latest .'
            }
        }

        stage('Push to DockerHub') {
            steps {
                withDockerRegistry(credentialsId: 'dockerhub', url: 'https://index.docker.io/v1/') {
                    sh 'docker tag convocationcheckin:latest chalsfptu/convocationcheckin:latest'
                    sh 'docker push chalsfptu/convocationcheckin:latest'
                }
            }
        }

        stage('Deploy') {
            steps {
                
                    echo 'Deploying and cleaning'
                    sh 'docker container stop convocationcheckin || echo "this container does not exist"'
                    sh 'echo y | docker system prune'
                    sh '''
                        docker container run -d --name convocationcheckin -p 85:80 chalsfptu/convocationcheckin
                    '''
                }
        }
    }

    post {
        always {
            cleanWs()
        }
    }
}
