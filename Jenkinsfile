node {

    stage 'Checkout'
        checkout scm       
    stage 'Build Images'	    
        sh "docker build -f services/dataservice ." 
       
    
}
