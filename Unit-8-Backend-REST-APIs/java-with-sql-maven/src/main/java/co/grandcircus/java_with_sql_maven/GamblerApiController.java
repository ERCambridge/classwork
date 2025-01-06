package co.grandcircus.java_with_sql_maven;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class GamblerApiController {
    
    @Autowired 
    private GamblerRepository gamblerRepo;

    @GetMapping("/")
	public String testMethod() {
		return "Test";
	}

    @GetMapping("/gamblers")
    public List<Gambler> getAllGamblers(){
        return gamblerRepo.findAll();
    }


}
