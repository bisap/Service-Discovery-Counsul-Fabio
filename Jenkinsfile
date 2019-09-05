node {

    stage 'Checkout'
        checkout scm       
    stage 'Build Images'	    
        sh "docker build -t consulservice   -f services/dataservice ." 
       
    
}
