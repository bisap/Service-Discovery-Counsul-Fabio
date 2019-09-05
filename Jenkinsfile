node {

    stage 'Checkout'
        checkout scm       
    stage 'TestCoverage'	    
        sh "docker-compose -f services/Consul-fabio.yml up" 
       
    
}
